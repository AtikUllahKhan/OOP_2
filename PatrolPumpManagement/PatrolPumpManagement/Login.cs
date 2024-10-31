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
using Microsoft.SqlServer.Server;

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

			
			string sql = "SELECT * FROM UserInfo WHERE ID='"+this.txtUserId.Text+"' AND Password= "+this.txtPassword.Text+" ";
            var ds = this.Pr.ExecuteQuery(sql);
            try
			{

				if (ds.Tables[0].Rows.Count ==1)
				{
					//MessageBox.Show("Valid User");
					if (ds.Tables[0].Rows[0][1].ToString() == "manager")
					{
						FormManager fa = new FormManager();
						fa.Visible =true;
						this.Hide();
					}
					else
					{
						FormSalesman fs = new FormSalesman();
						fs.Show();
						this.Hide();
					}
				}
				else
				{
					MessageBox.Show("Invalid User");
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
