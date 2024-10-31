using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PatrolPumpManagement
{
	public partial class FormManager : Form
	{
       
        public FormManager()
		{
			InitializeComponent();
		}

        private void btnSalesman_Click(object sender, EventArgs e)
        {
            /* FormSmAdd smAdd = new FormSmAdd();
             smAdd.Visible = true;
             this.Hide();*/
            loadfrom(new FormSmAdd());
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Login back = new Login();
            back.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            loadfrom(new FormProductAdd());
        } 

        
        public void loadfrom(object Form)
        {
            if (this.mainPanel.Controls.Count > 0) 
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
    }
}
