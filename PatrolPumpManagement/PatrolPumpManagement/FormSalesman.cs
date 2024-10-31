using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PatrolPumpManagement
{
    public partial class FormSalesman : Form
    {
        double total = 0, change;
        DataTable dt = new DataTable();
        private Project Pr { get; set; }
        SqlConnection con = new SqlConnection(@"Data Source=Atik-Khan;Initial Catalog=""Petrol Pump Management"";User ID=sa;Password=atik");
        public FormSalesman()
        {
            InitializeComponent();
            this.Pr = new Project();
           // this.AutoIdGenerate();


        }
        private void PopulateGridView(string sql = "SELECT * FROM OrderInfo;")
        {
            var ds = this.Pr.ExecuteQuery(sql);
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.DataSource = ds.Tables[0];
        }

        private void FormSalesman_Load(object sender, EventArgs e)
        {
            this.dgvOrder.ClearSelection();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dt.Clear();
            dt.Columns.Add("Oil_Name");
            dt.Columns.Add("price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total");

        }

        private void txtOilName_KeyUp(object sender, KeyEventArgs e)
        {
            listBoxProduct.Visible = true;
            listBoxProduct.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ProductInfo WHERE Oil_Name like '%" + this.txtOilName.Text + "%';";
            //var sql = "SELECT * FROM ProductInfo WHERE Oil_Name like '%" + this.txtOilName.Text + "%';";
            //var Count = this.Pr.ExecuteDMLQuery(sql);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                listBoxProduct.Items.Add(dr["Oil_Name"].ToString());
            }
        }

        private void txtOilName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxProduct.Focus();
                listBoxProduct.SelectedIndex = 0;
            }
        }

        private void listBoxProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listBoxProduct.SelectedIndex = this.listBoxProduct.SelectedIndex + 1;
                }
                if (e.KeyCode == Keys.Up)
                {
                    this.listBoxProduct.SelectedIndex = this.listBoxProduct.SelectedIndex - 1;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    this.txtOilName.Text = this.listBoxProduct.SelectedItem.ToString();
                    this.listBoxProduct.Visible = false;
                    this.listBoxProduct.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ProductInfo WHERE Oil_Name ='" + this.txtOilName.Text + "' order by Oil_Name desc ;";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    this.txtPrice.Text = dr["Price"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void txtQunatity_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtTotal.Text = Convert.ToString(Convert.ToInt32(this.txtPrice.Text) * Convert.ToInt32(this.txtQunatity.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }

        }
        /*private void AutoIdGenerate()
        {
            var sql = "select OrderId from OrderInfo order by OrderId desc;";
            var dt = this.Pr.ExecuteQueryTable(sql);
            var oldID = dt.Rows[0][0].ToString();
            string[] s = oldID.Split('-');
            int temp = Convert.ToInt32(s[1]);
            string newID = "Od-" + (++temp).ToString("d3");
            this.txtOrderID.Text = newID;
        }*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the data");
                    return;
                }
                int stock = 0;

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT * FROM ProductInfo  ;";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt1);
                foreach (DataRow dr1 in dt1.Rows)
                {
                    stock = Convert.ToInt32(dr1["Quantity"].ToString());
                }
                if (Convert.ToInt32(txtQunatity.Text) > stock)
                {
                    MessageBox.Show("This Much value is not Avaiable");
                }
                else
                {
                    DataRow dr = dt.NewRow();
                    dr["Oil_Name"] = this.txtOilName.Text;
                    dr["Price"] = this.txtPrice.Text;
                    dr["Quantity"] = this.txtQunatity.Text;
                    dr["Total"] = this.txtTotal.Text;
                    dt.Rows.Add(dr);
                    dgvOrder.DataSource = dt;
                    total = total + Convert.ToInt32(dr["Total"].ToString());
                    this.txtGrandTotal.Text = "Tk " + total.ToString();
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
            this.txtQunatity.Clear();
            this.txtOilName.Clear();
            this.txtTotal.Clear();
            this.txtOrderID.Clear();
            this.dtpPurchaseDate.Text = "";
            this.cmbPaymentType.SelectedIndex = -1;
            

            this.dgvOrder.ClearSelection();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           try
            {
                if (this.dgvOrder.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                total = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dgvOrder.CurrentCell.RowIndex.ToString()));
                foreach (DataRow dr1 in dt.Rows) 
                {
                    total = total + Convert.ToInt32(dr1["Total"].ToString());
                    this.txtGrandTotal.Text = total.ToString();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Login back = new Login();
            back.Show();

        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtOilName.Text) ||
                String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.txtQunatity.Text))
                return false;
            else
                return true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into OrderInfo values('" + this.txtOrderID.Text + "','" + this.cmbPaymentType.Text + "','" + this.dtpPurchaseDate.Text + "','" + this.txtGrandTotal.Text + "');";
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT * FROM OrderInfo Order by OrderId desc ";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                foreach (DataRow dr2 in dt2.Rows)
                {
                     string OrderId = dr2["OrderId"].ToString();

                }
                foreach (DataRow dr in dt.Rows)
                {
                    int quantity = 0;
                    String oname = "";

                    quantity = Convert.ToInt32(dr["Quantity"].ToString());
                    oname = dr["Oil_Name"].ToString();

                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "Update ProductInfo set Quantity=Quantity - " + quantity + " where Oil_Name ='" + oname.ToString() + "'; ";
                    cmd3.ExecuteNonQuery();
                }
                double cash = Convert.ToDouble(txtCash.Text);
                change = cash - total;
                if (change < 0)
                {
                    MessageBox.Show("Not Enough Cash");
                }
                txtChange.Text = "Tk " + change.ToString();

                this.ClearContent();
                dt.Clear();
                dgvOrder.DataSource = dt;
                this.txtGrandTotal.Clear();
                this.txtCash.Clear();
                


                MessageBox.Show("Order Confirm " + "\tTotal Taka " + total.ToString() + "\tReturn Money " + change.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }



        }
       
    } 

}
