namespace PatrolPumpManagement
{
    partial class FormProductAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvProductHead = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvProductCell = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvProductAlt = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlFormCard = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblOil = new System.Windows.Forms.Label();
            this.txtOilName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.Oil_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // dgvProductHead
            dgvProductHead.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvProductHead.BackColor = System.Drawing.Color.FromArgb(15, 42, 67);
            dgvProductHead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvProductHead.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvProductHead.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgvProductHead.SelectionBackColor = System.Drawing.Color.FromArgb(15, 42, 67);
            dgvProductHead.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvProductHead.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            // dgvProductCell
            dgvProductCell.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvProductCell.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvProductCell.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvProductCell.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvProductCell.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgvProductCell.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dgvProductCell.SelectionForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            dgvProductCell.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            // dgvProductAlt
            dgvProductAlt.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvProductAlt.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvProductAlt.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dgvProductAlt.SelectionForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(8, 0, 24, 24);
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // dgvProduct
            // 
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dgvProductAlt;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dgvProductHead;
            this.dgvProduct.ColumnHeadersHeight = 38;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.DefaultCellStyle = dgvProductCell;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowTemplate.Height = 34;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Oil_Name,
                this.Price,
                this.Quantity});
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // Oil_Name
            // 
            this.Oil_Name.DataPropertyName = "Oil_Name";
            this.Oil_Name.FillWeight = 40F;
            this.Oil_Name.HeaderText = "Oil name";
            this.Oil_Name.Name = "Oil_Name";
            this.Oil_Name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 30F;
            this.Price.HeaderText = "Price (Tk)";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 30F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Size = new System.Drawing.Size(100, 60);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtAutoSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutoSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtAutoSearch.Location = new System.Drawing.Point(16, 16);
            this.txtAutoSearch.Size = new System.Drawing.Size(320, 27);
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnShowDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnShowDetails.Location = new System.Drawing.Point(348, 14);
            this.btnShowDetails.Size = new System.Drawing.Size(100, 32);
            this.btnShowDetails.Text = "Show all";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.FlatAppearance.BorderSize = 0;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForm.Size = new System.Drawing.Size(340, 100);
            this.pnlForm.Padding = new System.Windows.Forms.Padding(24, 0, 8, 24);
            // 
            // pnlFormCard
            // 
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            this.lblFormTitle.Location = new System.Drawing.Point(20, 18);
            this.lblFormTitle.Text = "Product details";
            // 
            // lblOil
            // 
            this.lblOil.Name = "lblOil";
            this.lblOil.AutoSize = true;
            this.lblOil.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOil.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblOil.Location = new System.Drawing.Point(20, 62);
            this.lblOil.Text = "Oil name";
            // 
            // txtOilName
            // 
            this.txtOilName.Name = "txtOilName";
            this.txtOilName.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtOilName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOilName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOilName.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtOilName.Location = new System.Drawing.Point(20, 84);
            this.txtOilName.Size = new System.Drawing.Size(268, 27);
            // 
            // lblPrice
            // 
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPrice.Location = new System.Drawing.Point(20, 126);
            this.lblPrice.Text = "Price (Tk)";
            // 
            // txtPrice
            // 
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtPrice.Location = new System.Drawing.Point(20, 148);
            this.txtPrice.Size = new System.Drawing.Size(268, 27);
            // 
            // lblQty
            // 
            this.lblQty.Name = "lblQty";
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblQty.Location = new System.Drawing.Point(20, 190);
            this.lblQty.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtQuantity.Location = new System.Drawing.Point(20, 212);
            this.txtQuantity.Size = new System.Drawing.Size(268, 27);
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAdd.Location = new System.Drawing.Point(20, 268);
            this.btnAdd.Size = new System.Drawing.Size(268, 42);
            this.btnAdd.Text = "Add / Update";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnDelete.Location = new System.Drawing.Point(20, 320);
            this.btnDelete.Size = new System.Drawing.Size(130, 38);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Name = "btnClear";
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnClear.Location = new System.Drawing.Point(158, 320);
            this.btnClear.Size = new System.Drawing.Size(130, 38);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTip
            // 
            this.lblTip.Name = "lblTip";
            this.lblTip.AutoSize = false;
            this.lblTip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTip.Location = new System.Drawing.Point(20, 376);
            this.lblTip.Text = "Tip: click a row in the table to edit it.";
            this.lblTip.Size = new System.Drawing.Size(268, 36);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(100, 72);
            // 
            // lblTitle
            // 
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            this.lblTitle.Location = new System.Drawing.Point(24, 12);
            this.lblTitle.Text = "Products";
            // 
            // lblSub
            // 
            this.lblSub.Name = "lblSub";
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSub.Location = new System.Drawing.Point(26, 46);
            this.lblSub.Text = "Add, update or remove fuel and oil items";
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            // pnlGrid children
            this.pnlGrid.Controls.Add(this.pnlGridCard);
            // pnlGridCard children
            this.pnlGridCard.Controls.Add(this.dgvProduct);
            this.pnlGridCard.Controls.Add(this.pnlSearch);
            // pnlSearch children
            this.pnlSearch.Controls.Add(this.txtAutoSearch);
            this.pnlSearch.Controls.Add(this.btnShowDetails);
            // pnlForm children
            this.pnlForm.Controls.Add(this.pnlFormCard);
            // pnlFormCard children
            this.pnlFormCard.Controls.Add(this.lblFormTitle);
            this.pnlFormCard.Controls.Add(this.lblOil);
            this.pnlFormCard.Controls.Add(this.txtOilName);
            this.pnlFormCard.Controls.Add(this.lblPrice);
            this.pnlFormCard.Controls.Add(this.txtPrice);
            this.pnlFormCard.Controls.Add(this.lblQty);
            this.pnlFormCard.Controls.Add(this.txtQuantity);
            this.pnlFormCard.Controls.Add(this.btnAdd);
            this.pnlFormCard.Controls.Add(this.btnDelete);
            this.pnlFormCard.Controls.Add(this.btnClear);
            this.pnlFormCard.Controls.Add(this.lblTip);
            // pnlHeader children
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProductAdd";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FormProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlFormCard.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oil_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblOil;
        private System.Windows.Forms.TextBox txtOilName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
    }
}
