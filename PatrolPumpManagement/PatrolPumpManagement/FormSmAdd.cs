using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrolPumpManagement
{
    public partial class FormSmAdd : Form
    {
        private Project Pr { get; set; }

        // password of the row that was clicked, so we know when the manager changed it
        private string loadedPassword = "";

        public FormSmAdd()
        {
            InitializeComponent();
            this.Pr = new Project();
        }

        private void FormSmAdd_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;      // the Visual Studio designer must not touch the database

            Util.SetCue(this.txtAutoSearch, "Search by name, ID or phone...");
            try
            {
                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        // Salesman + login info joined by ID. 'where' is added for searching.
        private void PopulateGridView(string where = "", params SqlParameter[] ps)
        {
            string sql = "SELECT S.ID, S.Name, S.PhoneNo, S.Salary, S.JoiningDate, U.UserType, U.Password " +
                         "FROM SalesManInfo S, UserInfo U WHERE S.ID = U.ID " + where + " ORDER BY S.ID;";
            var ds = this.Pr.ExecuteQuery(sql, ps);
            this.dgvSalesMan.AutoGenerateColumns = false;
            this.dgvSalesMan.DataSource = ds.Tables[0];
            this.dgvSalesMan.ClearSelection();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.txtAutoSearch.Clear();
            this.PopulateGridView();
        }

        // live search: name, ID or phone
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string like = "%" + this.txtAutoSearch.Text.Trim() + "%";
                this.PopulateGridView("AND (S.Name LIKE @t OR S.ID LIKE @t OR S.PhoneNo LIKE @t)", Project.P("@t", like));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        // the password column shows dots; the real password is only in the Password box
        private void dgvSalesMan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            string col = this.dgvSalesMan.Columns[e.ColumnIndex].Name;
            if (col == "Password")
            {
                e.Value = "\u2022\u2022\u2022\u2022\u2022\u2022";
                e.FormattingApplied = true;
            }
            else if (col == "JoiningDate" && e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToString("yyyy-MM-dd");
                e.FormattingApplied = true;
            }
        }

        // ---------- automatic login (username + password) ----------

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            this.txtPassword.Text = Util.GeneratePassword();
            this.chkShowPassword.Checked = true;       // so the manager can read it
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = !this.chkShowPassword.Checked;
        }

        // Shows the new login so the manager can give it to the salesman
        private void ShowLoginDetails(string id, string name, string password, bool isNew)
        {
            string text = (isNew ? "Salesman added. Login created:" : "Password changed. New login:") +
                          "\n\nUsername:  " + id + "\nPassword:  " + password +
                          "\n\nGive these to " + name + ". They sign in on the Login screen." +
                          "\n\nCopy these details to the clipboard?";

            if (MessageBox.Show(text, "Login details", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try { Clipboard.SetText("Username: " + id + "\r\nPassword: " + password); }
                catch { MessageBox.Show("Could not copy. Please write the details down."); }
            }
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtName.Text.Trim()) ||
                String.IsNullOrEmpty(this.txtSalary.Text)|| String.IsNullOrEmpty(this.txtPassword.Text) ||
                String.IsNullOrEmpty(this.cmbUserType.Text))
                return false;
            else
                return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the data");
                    return;
                }

                // check the values before saving
                string userType = this.cmbUserType.Text.Trim().ToLower();
                decimal salary;
                if (!decimal.TryParse(this.txtSalary.Text, out salary) || salary < 0)
                {
                    MessageBox.Show("Salary must be a number (0 or more)");
                    return;
                }
                if (this.txtPassword.Text.Length < 4)
                {
                    MessageBox.Show("Password must have at least 4 characters. Use Generate for a new one.");
                    return;
                }

                string id = this.txtID.Text.Trim();
                string name = this.txtName.Text.Trim();
                string phone = this.txtPhoneNo.Text.Trim();       // phone is text, so 018... keeps its zero
                DateTime joining = this.dtpJoiningDate.Value.Date;
                string password = this.txtPassword.Text;

                var query = "select * from SalesManInfo where ID = @id;";
                var ds = this.Pr.ExecuteQuery(query, Project.P("@id", id));
                bool exists = ds.Tables[0].Rows.Count == 1;

                // SalesManInfo and UserInfo are saved together: if one fails, nothing is saved.
                using (SqlConnection con = this.Pr.NewConnection())
                {
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        if (exists)
                        {
                            //update
                            Project.ExecInTx(con, tx,
                                @"update SalesManInfo set Name = @n, PhoneNo = @ph, Salary = @s, JoiningDate = @d where ID = @id;",
                                Project.P("@n", name), Project.P("@ph", phone), Project.P("@s", salary),
                                Project.P("@d", joining), Project.P("@id", id));
                            Project.ExecInTx(con, tx,
                                @"update UserInfo set UserType = @t, Name = @n, Password = @pw where ID = @id;",
                                Project.P("@t", userType), Project.P("@n", name), Project.P("@pw", password), Project.P("@id", id));
                        }
                        else
                        {
                            //insert: the salesman AND his login (username = ID, password) are created together
                            Project.ExecInTx(con, tx,
                                "insert into SalesManInfo values(@id, @n, @ph, @s, @d);",
                                Project.P("@id", id), Project.P("@n", name), Project.P("@ph", phone),
                                Project.P("@s", salary), Project.P("@d", joining));
                            Project.ExecInTx(con, tx,
                                "insert into UserInfo values(@id, @t, @n, @pw);",
                                Project.P("@id", id), Project.P("@t", userType), Project.P("@n", name), Project.P("@pw", password));
                        }
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }

                if (!exists || password != this.loadedPassword)
                    this.ShowLoginDetails(id, name, password, !exists);      // new login or new password
                else
                    MessageBox.Show("Data updated Properly");

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        // Empties the boxes and prepares the NEXT salesman: new ID (= username) and a new password
        private void ClearContent()
        {
            this.txtName.Clear();
            this.txtPhoneNo.Clear();
            this.txtSalary.Clear();
            this.dtpJoiningDate.Value = DateTime.Today;
            this.cmbUserType.SelectedIndex = 0;
            this.loadedPassword = "";

            this.txtAutoSearch.TextChanged -= this.txtAutoSearch_TextChanged;
            this.txtAutoSearch.Clear();
            this.txtAutoSearch.TextChanged += this.txtAutoSearch_TextChanged;

            this.dgvSalesMan.ClearSelection();
            this.AutoIdGenerate();
            this.txtPassword.Text = Util.GeneratePassword();
            this.chkShowPassword.Checked = true;
            this.txtName.Focus();
        } 

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
            this.PopulateGridView();
        }

        // Next salesman ID = biggest sm-number + 1 (also works when the table is empty)
        private void AutoIdGenerate()
        {
            int max = 0;
            var dt = this.Pr.ExecuteQueryTable("select ID from SalesManInfo where ID like 'sm-%';");
            foreach (DataRow row in dt.Rows)
            {
                string[] s = row[0].ToString().Split('-');
                int n;
                if (s.Length == 2 && int.TryParse(s[1], out n) && n > max)
                    max = n;
            }
            this.txtID.Text = "sm-" + (max + 1).ToString("d3");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvSalesMan.CurrentRow == null || this.dgvSalesMan.CurrentRow.Cells["ID"].Value == null)
                {
                    MessageBox.Show("Please select a row first to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var ID = this.dgvSalesMan.CurrentRow.Cells["ID"].Value.ToString();
                var Name = this.dgvSalesMan.CurrentRow.Cells["NickName"].Value.ToString();

                DialogResult d = MessageBox.Show($"Are you sure you want to remove {Name}? Their login will be removed too.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.No)
                    return;

                // Delete by ID in both tables (before, UserInfo was deleted by Password, which could remove other users)
                using (SqlConnection con = this.Pr.NewConnection())
                {
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        Project.ExecInTx(con, tx, "delete from UserInfo where ID = @id;", Project.P("@id", ID));
                        Project.ExecInTx(con, tx, "delete from SalesManInfo where ID = @id;", Project.P("@id", ID));
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }

                MessageBox.Show(Name.ToUpper() + " has been deleted Properly");

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        // click a row in the table -> its data goes into the boxes (so you can update it or give a new password)
        private void dgvSalesMan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = this.dgvSalesMan.Rows[e.RowIndex];
            this.txtID.Text = r.Cells["ID"].Value.ToString();
            this.txtName.Text = r.Cells["NickName"].Value.ToString();
            this.txtPhoneNo.Text = r.Cells["PhoneNo"].Value.ToString();
            this.txtSalary.Text = r.Cells["Salary"].Value.ToString();
            this.cmbUserType.Text = r.Cells["UserType"].Value.ToString().Trim().ToLower();
            this.loadedPassword = r.Cells["Password"].Value.ToString();
            this.chkShowPassword.Checked = false;
            this.txtPassword.Text = this.loadedPassword;
            DateTime joined;
            if (DateTime.TryParse(r.Cells["JoiningDate"].Value.ToString(), out joined))
                this.dtpJoiningDate.Value = joined;
        }
    }
 
}
