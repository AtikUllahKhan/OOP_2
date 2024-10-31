using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
        public FormSmAdd()
        {
            InitializeComponent();
            this.Pr = new Project();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "SELECT S.* ,U.* FROM SalesManInfo S ,UserInfo U Where S.ID = U.ID;")
        {
            var ds = this.Pr.ExecuteQuery(sql);
            this.dgvSalesMan.AutoGenerateColumns = false;
            this.dgvSalesMan.DataSource = ds.Tables[0];
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager back = new FormManager();
            back.Show();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {  
            this.PopulateGridView();      
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = @"SELECT * FROM SalesManInfo where ID = '" + this.txtSearch.Text + "' or Name = '" + this.txtSearch.Text + "' " +
                   " or PhoneNo = '" + this.txtSearch.Text + "' ;";
                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("An error has occured: " + ex.Message);
                }
            }
            
        }
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from SalesManInfo where Name like '%" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("An error has occured: " + ex.Message);
                }
            }
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtName.Text) ||
                String.IsNullOrEmpty(this.txtSalary.Text)|| String.IsNullOrEmpty(this.txtPassword.Text) ||
                String.IsNullOrEmpty(this.txtUserType.Text))
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

                var query = "select * from SalesManInfo where ID = '"+this.txtID.Text+"'; ";
                var ds = this.Pr.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update SalesManInfo
                                set ID = '" + this.txtID.Text + @"',
                                Name = ' " + this.txtName.Text + @"',
                                PhoneNo = " + this.txtPhoneNo.Text + @",
                                Salary = " + this.txtSalary.Text + @",
                                JoiningDate = '" + this.dtpJoiningDate.Text + @"'
                                where ID = '" + this.txtID.Text + "';";
                    var count = this.Pr.ExecuteDMLQuery(sql);
                    var sql1 = @"update UserInfo
                                set ID = '" + this.txtID.Text + @"',               
                                UserType = '"+this.txtUserType.Text + @"',
                                Name = '"+this.txtName.Text+ @"',
                                Password =  " + this.txtPassword.Text + @"
                                where ID = '" + this.txtID.Text + "';";
                    var count1 = this.Pr.ExecuteDMLQuery(sql1);


                    if (count == 1)
                        MessageBox.Show("Data updated Properly");
                    else
                        MessageBox.Show("Data upgradation Failed");
                   
                }
                else
                {
                    //insert
                    var sql = "insert into SalesManInfo values('" + this.txtID.Text + "', '" + this.txtName.Text + "', " + this.txtPhoneNo.Text + ", " + this.txtSalary.Text + ", '" + this.dtpJoiningDate.Text + "'); ";
                    var count = this.Pr.ExecuteDMLQuery(sql);
                    var sql1 = "insert into UserInfo values('" + this.txtID.Text + "', '" + this.txtUserType.Text+"','" + this.txtName.Text + "',"+this.txtPassword.Text+"); ";
                    
                    var count1 = this.Pr.ExecuteDMLQuery(sql1);

                    if (count == 1)
                        MessageBox.Show("Data Added Properly");
                    else
                        MessageBox.Show("Data Insertion Failed");
                    

                }

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }
        private void ClearContent()
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.txtPhoneNo.Clear();
            this.txtSalary.Clear();
            this.dtpJoiningDate.Text = "";
            this.txtUserType.Clear();
            this.txtPassword.Clear();


            this.txtSearch.Clear();
            this.txtAutoSearch.Clear();

            this.dgvSalesMan.ClearSelection();
            this.AutoIdGenerate();
           
        } 

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
        private void AutoIdGenerate()
        {
            var sql = "select Id from SalesManInfo order by ID desc;";
            var dt = this.Pr.ExecuteQueryTable(sql);
            var oldID = dt.Rows[0][0].ToString();
            string[] s = oldID.Split('-');
            int temp = Convert.ToInt32(s[1]);
            string newID = "sm-" + (++temp).ToString("d3");
            this.txtID.Text = newID;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvSalesMan.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var ID = this.dgvSalesMan.CurrentRow.Cells["ID"].Value.ToString();
                var Name = this.dgvSalesMan.CurrentRow.Cells["NickName"].Value.ToString();
                var Password = this.dgvSalesMan.CurrentRow.Cells["Password"].Value.ToString();
                var Usertype = this.dgvSalesMan.CurrentRow.Cells["UserType"].Value.ToString();

                DialogResult d = MessageBox.Show($"Are you sure you want to remove {NickName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.No)
                    return;

                var sql = "delete from SalesManInfo where ID = '" + ID + "';";
                var count = this.Pr.ExecuteDMLQuery(sql);
                var sql1 = "delete from UserInfo where Password = '" + Password + "';";
                var count1 = this.Pr.ExecuteDMLQuery(sql1);

                if (count == 1)
                    MessageBox.Show(Name.ToUpper() + " has been deleted Properly");
                else
                    MessageBox.Show("Data deletion Failed");
                

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void FormSmAdd_Load(object sender, EventArgs e)
        {
            this.dgvSalesMan.ClearSelection();
        }
    }
 
}
