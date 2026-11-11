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
        }

        private void PopulateGridView(string sql = "SELECT * FROM ProductInfo;", params System.Data.SqlClient.SqlParameter[] ps)
        {
            var ds = this.Pr.ExecuteQuery(sql, ps);
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
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

                // check that Price and Quantity are real numbers
                decimal price; int quantity;
                if (!decimal.TryParse(this.txtPrice.Text, out price) || price < 0)
                {
                    MessageBox.Show("Price must be a number (0 or more)");
                    return;
                }
                if (!int.TryParse(this.txtQuantity.Text, out quantity) || quantity < 0)
                {
                    MessageBox.Show("Quantity must be a whole number (0 or more)");
                    return;
                }
                string oilName = this.txtOilName.Text.Trim();

                var query = "select * from ProductInfo where Oil_Name = @n;";
                var ds = this.Pr.ExecuteQuery(query, Project.P("@n", oilName));

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update ProductInfo set Price = @p, Quantity = @q where Oil_Name = @n;";
                    var count = this.Pr.ExecuteDMLQuery(sql,
                        Project.P("@p", price), Project.P("@q", quantity), Project.P("@n", oilName));

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
                    var sql = "insert into ProductInfo values(@n, @p, @q);";
                    var count = this.Pr.ExecuteDMLQuery(sql,
                        Project.P("@n", oilName), Project.P("@p", price), Project.P("@q", quantity));

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
                string text = this.txtAutoSearch.Text.Trim();
                string sql = "select * from ProductInfo where Oil_Name like @t or convert(varchar(50), Price) = @e;";
                this.PopulateGridView(sql, Project.P("@t", "%" + text + "%"), Project.P("@e", text));
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
            if (String.IsNullOrEmpty(this.txtOilName.Text.Trim()) || String.IsNullOrEmpty(this.txtPrice.Text) ||
                String.IsNullOrEmpty(this.txtQuantity.Text))
                return false;
            else 
                return true;
        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.CurrentRow == null || this.dgvProduct.CurrentRow.Cells["Oil_Name"].Value == null)
                {
                    MessageBox.Show("Please select a row first to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                var Oil_Name = this.dgvProduct.CurrentRow.Cells["Oil_Name"].Value.ToString();

                DialogResult d = MessageBox.Show($"Are you sure you want to remove {Oil_Name}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.No)
                    return;

                var sql = "delete from ProductInfo where Oil_Name = @n;";
                var count = this.Pr.ExecuteDMLQuery(sql, Project.P("@n", Oil_Name));

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

        // NEW: click a row in the table -> its data goes into the boxes (so you can change Price / Quantity)
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            this.txtOilName.Text = this.dgvProduct.Rows[e.RowIndex].Cells["Oil_Name"].Value.ToString();
            this.txtPrice.Text = this.dgvProduct.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            this.txtQuantity.Text = this.dgvProduct.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
        }

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;      // the Visual Studio designer must not touch the database

            Util.SetCue(this.txtAutoSearch, "Search by name or price...");
            try
            {
                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
            this.dgvProduct.ClearSelection();
        }

    }

    
    
}
