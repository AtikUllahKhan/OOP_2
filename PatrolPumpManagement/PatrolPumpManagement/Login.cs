using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PatrolPumpManagement
{
	public partial class Login : Form
	{
        private Project Pr { get; set; }
        public Login()
		{
			InitializeComponent();
            this.Pr = new Project();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
            if (this.txtUserId.Text.Trim() == "" || this.txtPassword.Text == "")
            {
                MessageBox.Show("Please enter User ID and Password");
                return;
            }

            try
			{
                // @id and @pw are parameters: whatever is typed can no longer change the SQL command
                string sql = "SELECT * FROM UserInfo WHERE ID = @id AND Password = @pw";
                var ds = this.Pr.ExecuteQuery(sql,
                    Project.P("@id", this.txtUserId.Text.Trim()),
                    Project.P("@pw", this.txtPassword.Text));

				if (ds.Tables[0].Rows.Count == 1)
				{
					if (ds.Tables[0].Rows[0]["UserType"].ToString().Trim().ToLower() == "manager")
					{
						FormManager fa = new FormManager();
                        fa.UserName = ds.Tables[0].Rows[0]["Name"].ToString();
                        fa.FormClosed += (s, args) => { this.btnClear_Click(null, null); this.Show(); };  // Back / close -> login comes back
						fa.Visible =true;
						this.Hide();
					}
					else
					{
						FormSalesman fs = new FormSalesman();
                        fs.UserName = ds.Tables[0].Rows[0]["Name"].ToString();
                        fs.FormClosed += (s, args) => { this.btnClear_Click(null, null); this.Show(); };
						fs.Show();
						this.Hide();
					}
				}
				else
				{
					MessageBox.Show("Invalid User ID or Password");
					this.txtPassword.Clear();
					this.txtPassword.Focus();
				}
                
            }
			catch (Exception ex)
			{
                MessageBox.Show("An error has occured: " + ex.Message);
            }
			
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtUserId.Clear();
			txtPassword.Clear();
             
			txtUserId.Focus();
		}
		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}
		private void btnView_Click(object sender, EventArgs e)
		{
			if (this.txtPassword.UseSystemPasswordChar)
			{
				this.txtPassword.UseSystemPasswordChar= false;
			}
			else
				this.txtPassword.UseSystemPasswordChar= true;

		}
    }
}
