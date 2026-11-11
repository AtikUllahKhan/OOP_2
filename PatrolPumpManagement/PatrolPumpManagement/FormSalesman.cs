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
    public partial class FormSalesman : Form
    {
        DataTable dt = new DataTable();      // the shopping cart
        private Project Pr { get; set; }

        // name shown in the top bar (set by Login)
        public string UserName { get; set; }

        public FormSalesman()
        {
            InitializeComponent();
            this.Pr = new Project();
        }

        private void FormSalesman_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;      // the Visual Studio designer must not touch the database

            this.lblUser.Text = "Cashier: " + (string.IsNullOrEmpty(this.UserName) ? "-" : this.UserName);

            // cart columns (numbers are real numbers, not text)
            dt.Columns.Add("Oil_Name", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Total", typeof(decimal));
            this.dgvOrder.DataSource = dt;
            this.dgvOrder.Columns["Oil_Name"].HeaderText = "Oil name";
            this.dgvOrder.Columns["Price"].HeaderText = "Price (Tk)";
            this.dgvOrder.Columns["Total"].HeaderText = "Total (Tk)";
            this.dgvOrder.ClearSelection();

            this.listBoxProduct.Visible = false;
            this.dtpPurchaseDate.Value = DateTime.Today;
            this.cmbPaymentType.SelectedIndex = 0;
            try
            {
                this.txtOrderID.Text = this.GetNextOrderId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
            Util.SetCue(this.txtOilName, "Type to search...");
        }

        // mouse click on a suggestion
        private void listBoxProduct_Click(object sender, EventArgs e)
        {
            this.ChooseProduct();
        }

        // change shows while typing the cash
        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            this.ShowChange();
        }

        // total of the line updates while typing the quantity
        private void txtQunatity_TextChanged(object sender, EventArgs e)
        {
            this.txtQunatity_Leave(sender, e);
        }

        // Next order id = biggest Od-number + 1  (old ids like "Atik" or "122222" are ignored)
        private string GetNextOrderId()
        {
            int max = 0;
            DataTable t = this.Pr.ExecuteQueryTable("SELECT OrderId FROM OrderInfo WHERE OrderId LIKE 'Od-%';");
            foreach (DataRow r in t.Rows)
            {
                string[] s = r[0].ToString().Split('-');
                int n;
                if (s.Length == 2 && int.TryParse(s[1], out n) && n > max)
                    max = n;
            }
            return "Od-" + (max + 1).ToString("d3");
        }

        // ---------- choose a product ----------

        private void txtOilName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
                return;

            try
            {
                listBoxProduct.Items.Clear();
                this.txtPrice.Clear();
                this.txtTotal.Clear();
                if (this.txtOilName.Text.Trim() == "")
                {
                    listBoxProduct.Visible = false;
                    return;
                }

                DataTable table = this.Pr.ExecuteQueryTable(
                    "SELECT * FROM ProductInfo WHERE Oil_Name like @t;",
                    Project.P("@t", "%" + this.txtOilName.Text.Trim() + "%"));

                foreach (DataRow dr in table.Rows)
                {
                    listBoxProduct.Items.Add(dr["Oil_Name"].ToString());
                }
                listBoxProduct.Visible = listBoxProduct.Items.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void txtOilName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && listBoxProduct.Items.Count > 0)
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
                    if (this.listBoxProduct.SelectedIndex < this.listBoxProduct.Items.Count - 1)     // do not go past the last item
                        this.listBoxProduct.SelectedIndex = this.listBoxProduct.SelectedIndex + 1;
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (this.listBoxProduct.SelectedIndex > 0)
                        this.listBoxProduct.SelectedIndex = this.listBoxProduct.SelectedIndex - 1;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    this.ChooseProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        // the product picked from the list goes into the Oil Name box and its price is shown
        private void ChooseProduct()
        {
            if (this.listBoxProduct.SelectedItem == null) return;
            this.txtOilName.Text = this.listBoxProduct.SelectedItem.ToString();
            this.listBoxProduct.Visible = false;
            this.txtPrice_Enter(null, null);
            this.txtQunatity.Focus();
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            try
            {
                DataTable table = this.Pr.ExecuteQueryTable(
                    "SELECT * FROM ProductInfo WHERE Oil_Name = @n;", Project.P("@n", this.txtOilName.Text.Trim()));

                if (table.Rows.Count == 1)
                    this.txtPrice.Text = table.Rows[0]["Price"].ToString();
                else
                    this.txtPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        // Total of this line = Price x Quantity  (decimals allowed, empty/wrong text does not crash)
        private void txtQunatity_Leave(object sender, EventArgs e)
        {
            decimal price; int qty;
            if (decimal.TryParse(this.txtPrice.Text, out price) && int.TryParse(this.txtQunatity.Text, out qty))
                this.txtTotal.Text = (price * qty).ToString();
            else
                this.txtTotal.Clear();
        }

        // ---------- cart ----------

        private decimal CartTotal()
        {
            decimal total = 0;
            foreach (DataRow r in dt.Rows)
                total += (decimal)r["Total"];
            return total;
        }

        private void ShowGrandTotal()
        {
            if (dt.Rows.Count == 0)
                this.txtGrandTotal.Clear();
            else
                this.txtGrandTotal.Text = "Tk " + this.CartTotal().ToString("0.##");
            this.ShowChange();
        }

        private void ShowChange()
        {
            decimal cash;
            if (dt.Rows.Count > 0 && decimal.TryParse(this.txtCash.Text, out cash))
                this.txtChange.Text = "Tk " + (cash - this.CartTotal()).ToString("0.##");
            else
                this.txtChange.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtOilName.Text.Trim() == "" || this.txtQunatity.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill all the data");
                    return;
                }

                int qty;
                if (!int.TryParse(this.txtQunatity.Text, out qty) || qty <= 0)
                {
                    MessageBox.Show("Quantity must be a whole number more than 0");
                    return;
                }

                // read THIS product from the database (price and stock)
                DataTable table = this.Pr.ExecuteQueryTable(
                    "SELECT * FROM ProductInfo WHERE Oil_Name = @n;", Project.P("@n", this.txtOilName.Text.Trim()));
                if (table.Rows.Count != 1)
                {
                    MessageBox.Show("This product was not found. Choose it from the list.");
                    return;
                }
                string oilName = table.Rows[0]["Oil_Name"].ToString();
                decimal price = Convert.ToDecimal(table.Rows[0]["Price"]);
                int stock = Convert.ToInt32(table.Rows[0]["Quantity"]);

                // quantity of the same product already in the cart
                int inCart = 0;
                foreach (DataRow r in dt.Rows)
                    if (r["Oil_Name"].ToString() == oilName)
                        inCart += (int)r["Quantity"];

                if (qty + inCart > stock)
                {
                    MessageBox.Show("This Much value is not Avaiable. Stock: " + stock + ", already in cart: " + inCart);
                }
                else
                {
                    dt.Rows.Add(oilName, price, qty, price * qty);
                    this.ShowGrandTotal();
                    this.ClearContent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        // clears only the item boxes (not the order id / payment / date)
        private void ClearContent()
        {
            this.txtPrice.Clear();
            this.txtQunatity.Clear();
            this.txtOilName.Clear();
            this.txtTotal.Clear();
            this.listBoxProduct.Visible = false;

            this.dgvOrder.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           try
            {
                if (this.dgvOrder.CurrentRow == null || this.dgvOrder.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dt.Rows.RemoveAt(this.dgvOrder.CurrentRow.Index);
                this.ShowGrandTotal();      // also correct when the last item is removed
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();      // Login shows again by itself (see Login.cs)
        }

        // ---------- confirm the order ----------

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("The cart is empty. Add an item first.");
                    return;
                }
                if (this.cmbPaymentType.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select Payment Type");
                    return;
                }

                bool isCash = this.cmbPaymentType.Text == "Cash";
                decimal cash = 0;
                if (isCash && (!decimal.TryParse(this.txtCash.Text, out cash) || cash < 0))
                {
                    MessageBox.Show("Please enter the Cash received");
                    return;
                }

                string orderId = this.GetNextOrderId();
                decimal grand = 0;

                // Order + stock are saved together: if anything fails, NOTHING is saved
                using (SqlConnection con = this.Pr.NewConnection())
                {
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();
                    try
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            string oname = dr["Oil_Name"].ToString();
                            int quantity = (int)dr["Quantity"];

                            // current price from the database
                            SqlCommand getPrice = new SqlCommand("SELECT Price FROM ProductInfo WHERE Oil_Name = @n;", con, tx);
                            getPrice.Parameters.Add(Project.P("@n", oname));
                            object p = getPrice.ExecuteScalar();
                            if (p == null)
                                throw new Exception(oname + " was not found.");

                            // reduce the stock, but only if enough is left
                            int updated = Project.ExecInTx(con, tx,
                                "UPDATE ProductInfo SET Quantity = Quantity - @q WHERE Oil_Name = @n AND Quantity >= @q;",
                                Project.P("@q", quantity), Project.P("@n", oname));
                            if (updated != 1)
                                throw new Exception("Not enough stock for " + oname);

                            grand += Convert.ToDecimal(p) * quantity;
                        }

                        if (isCash && cash < grand)
                            throw new Exception("Not Enough Cash. Total is Tk " + grand.ToString("0.##"));

                        // same 4 columns as before: OrderId, Payment Type, Purchase Date, Total ("Tk 102")
                        Project.ExecInTx(con, tx, "INSERT INTO OrderInfo VALUES (@id, @pt, @d, @t);",
                            Project.P("@id", orderId),
                            Project.P("@pt", this.cmbPaymentType.Text),
                            Project.P("@d", this.dtpPurchaseDate.Value.Date),
                            Project.P("@t", "Tk " + grand.ToString("0.##")));

                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }

                decimal change = isCash ? cash - grand : 0;
                this.txtChange.Text = "Tk " + change.ToString("0.##");
                MessageBox.Show("Order Confirm: " + orderId + "\tTotal Taka " + grand.ToString("0.##") + "\tReturn Money " + change.ToString("0.##"));

                // ready for the next customer (the total starts from 0 again)
                dt.Clear();
                this.ClearContent();
                this.txtGrandTotal.Clear();
                this.txtCash.Clear();
                this.cmbPaymentType.SelectedIndex = 0;
                this.txtOrderID.Text = this.GetNextOrderId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }
       
    } 

}
