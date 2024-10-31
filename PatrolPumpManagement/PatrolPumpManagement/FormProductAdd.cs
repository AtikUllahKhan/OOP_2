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
    public partial class FormProductAdd : Form
    {
        private Project Pr { get; set; }
        public FormProductAdd()
        {
            InitializeComponent();
            this.Pr = new Project();
            this.PopulateGridView();
           
        }

        private void PopulateGridView(string sql = "SELECT * FROM ProductInfo;")
        {
            var ds = this.Pr.ExecuteQuery(sql);
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormManager back = new FormManager();
            back.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"SELECT * FROM ProductInfo where Oil_Name = '" + this.txtSearch.Text + "' or Price = '" + this.txtSearch.Text + "' ";
                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("An error has occured: " + ex.Message);
                }
            }
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

                var query = "select * from ProductInfo where Oil_Name = '" + this.txtOilName.Text + "';";
                var ds = this.Pr.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update ProductInfo
                                set 
                                Price = " + this.txtPrice.Text + @",
                                Quantity = " + this.txtQuantity.Text + @"
                                where Oil_Name = '" + this.txtOilName.Text + "';";
                    var count = this.Pr.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated Properly");
                    else
                        MessageBox.Show("Data upgradation Failed");

                    this.PopulateGridView();
                    this.ClearContent();
                }
                else
                {
                    //insert
                    var sql = "insert into ProductInfo values('" + this.txtOilName.Text + "', " + this.txtPrice.Text + ", " + this.txtQuantity.Text + "); ";
                    var count = this.Pr.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data Added Properly");
                    else
                        MessageBox.Show("Data Insertion Failed");


                    this.PopulateGridView();
                    this.ClearContent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }
       
        private void ClearContent()
        {
            this.txtPrice.Clear();
            this.txtQuantity.Clear();
            this.txtOilName.Clear();
            

            this.txtSearch.Clear();
            this.txtAutoSearch.Clear();

            this.dgvProduct.ClearSelection();
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }


        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from ProductInfo where Oil_Name like '%" + this.txtAutoSearch.Text + "%';";
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
            if (String.IsNullOrEmpty(this.txtOilName.Text) || String.IsNullOrEmpty(this.txtPrice.Text) ||
                String.IsNullOrEmpty(this.txtQuantity.Text))
                return false;
            else 
                return true;
        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                var Oil_Name = this.dgvProduct.CurrentRow.Cells["Oil_Name"].Value.ToString();

                DialogResult d = MessageBox.Show($"Are you sure you want to remove {Oil_Name}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.No)
                    return;

                var sql = "delete from ProductInfo where Oil_Name = '" + Oil_Name + "';";
                var count = this.Pr.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(Oil_Name.ToUpper() + " has been deleted Properly");
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

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            this.dgvProduct.ClearSelection();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
    
}
