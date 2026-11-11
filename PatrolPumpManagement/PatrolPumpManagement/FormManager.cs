using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrolPumpManagement
{
	public partial class FormManager : Form
	{
        private Project Pr { get; set; }

        // name shown in the top bar (set by Login)
        public string UserName { get; set; }

        public FormManager()
		{
			InitializeComponent();
            this.Pr = new Project();
		}

        private void FormManager_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;        // so the Visual Studio designer never touches the database

            this.lblUser.Text = "Welcome, " + (string.IsNullOrEmpty(this.UserName) ? "Manager" : this.UserName);
            this.ShowHome();
        }

        // Dashboard: removes the open screen and shows the 3 counters
        private void ShowHome()
        {
            this.CloseOpenScreen();
            this.pnlWelcome.Visible = true;
            this.SetActive(this.btnHome);

            try
            {
                this.lblProductCount.Text = this.Pr.ExecuteScalar("SELECT COUNT(*) FROM ProductInfo;").ToString();
                this.lblSalesmanCount.Text = this.Pr.ExecuteScalar("SELECT COUNT(*) FROM SalesManInfo;").ToString();
                this.lblOrderCount.Text = this.Pr.ExecuteScalar("SELECT COUNT(*) FROM OrderInfo;").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read the database: " + ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.ShowHome();
        }

        private void btnSalesman_Click(object sender, EventArgs e)
        {
            loadfrom(new FormSmAdd());
            this.SetActive(this.btnSalesman);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            loadfrom(new FormProductAdd());
            this.SetActive(this.btnProduct);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();      // Login shows again by itself (see Login.cs)
        }

        // the menu button of the open screen is shown in a lighter colour
        private void SetActive(Button active)
        {
            foreach (Button b in new Button[] { this.btnHome, this.btnProduct, this.btnSalesman })
                b.BackColor = (b == active) ? Color.FromArgb(27, 63, 99) : Color.FromArgb(15, 42, 67);
        }

        private void CloseOpenScreen()
        {
            foreach (Control c in this.mainPanel.Controls.Cast<Control>().ToList())
            {
                if (c is Form)
                {
                    this.mainPanel.Controls.Remove(c);
                    c.Dispose();            // free the old form
                }
            }
        }

        public void loadfrom(object Form)
        {
            Form f = Form as Form;
            if (f == null) return;

            this.CloseOpenScreen();
            this.pnlWelcome.Visible = false;

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
    }
}
