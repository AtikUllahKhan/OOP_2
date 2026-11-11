namespace PatrolPumpManagement
{
    partial class FormSalesman
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
            System.Windows.Forms.DataGridViewCellStyle dgvOrderHead = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvOrderCell = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvOrderAlt = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.pnlCartBottom = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlCartTop = new System.Windows.Forms.Panel();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.lblItemTitle = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.txtOilName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQunatity = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblOid = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.lblGrand = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlCart.SuspendLayout();
            this.pnlCartBottom.SuspendLayout();
            this.pnlCartTop.SuspendLayout();
            this.pnlSpacer.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLine.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // dgvOrderHead
            dgvOrderHead.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvOrderHead.BackColor = System.Drawing.Color.FromArgb(15, 42, 67);
            dgvOrderHead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvOrderHead.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvOrderHead.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgvOrderHead.SelectionBackColor = System.Drawing.Color.FromArgb(15, 42, 67);
            dgvOrderHead.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvOrderHead.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            // dgvOrderCell
            dgvOrderCell.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvOrderCell.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvOrderCell.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvOrderCell.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvOrderCell.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgvOrderCell.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dgvOrderCell.SelectionForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            dgvOrderCell.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            // dgvOrderAlt
            dgvOrderAlt.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvOrderAlt.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvOrderAlt.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dgvOrderAlt.SelectionForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 20;
            this.listBoxProduct.Location = new System.Drawing.Point(36, 173);
            this.listBoxProduct.Size = new System.Drawing.Size(230, 124);
            this.listBoxProduct.Visible = false;
            this.listBoxProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxProduct_KeyDown);
            this.listBoxProduct.Click += new System.EventHandler(this.listBoxProduct_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20, 16, 20, 20);
            // 
            // pnlCart
            // 
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // dgvOrder
            // 
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dgvOrderAlt;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dgvOrderHead;
            this.dgvOrder.ColumnHeadersHeight = 38;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrder.DefaultCellStyle = dgvOrderCell;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 34;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // pnlCartBottom
            // 
            this.pnlCartBottom.Name = "pnlCartBottom";
            this.pnlCartBottom.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlCartBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCartBottom.Size = new System.Drawing.Size(100, 56);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnDelete.Location = new System.Drawing.Point(16, 10);
            this.btnDelete.Size = new System.Drawing.Size(150, 36);
            this.btnDelete.Text = "Remove selected";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlCartTop
            // 
            this.pnlCartTop.Name = "pnlCartTop";
            this.pnlCartTop.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlCartTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCartTop.Size = new System.Drawing.Size(100, 44);
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.AutoSize = true;
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            this.lblCartTitle.Location = new System.Drawing.Point(16, 12);
            this.lblCartTitle.Text = "Current order";
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpacer.Size = new System.Drawing.Size(100, 14);
            // 
            // pnlItem
            // 
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItem.Size = new System.Drawing.Size(100, 108);
            // 
            // lblItemTitle
            // 
            this.lblItemTitle.Name = "lblItemTitle";
            this.lblItemTitle.AutoSize = true;
            this.lblItemTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemTitle.ForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            this.lblItemTitle.Location = new System.Drawing.Point(16, 10);
            this.lblItemTitle.Text = "Add item";
            // 
            // lblO
            // 
            this.lblO.Name = "lblO";
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblO.Location = new System.Drawing.Point(16, 40);
            this.lblO.Text = "Oil name";
            // 
            // lblP
            // 
            this.lblP.Name = "lblP";
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblP.Location = new System.Drawing.Point(262, 40);
            this.lblP.Text = "Price";
            // 
            // lblQ
            // 
            this.lblQ.Name = "lblQ";
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblQ.Location = new System.Drawing.Point(378, 40);
            this.lblQ.Text = "Quantity";
            // 
            // lblT
            // 
            this.lblT.Name = "lblT";
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblT.Location = new System.Drawing.Point(494, 40);
            this.lblT.Text = "Total";
            // 
            // txtOilName
            // 
            this.txtOilName.Name = "txtOilName";
            this.txtOilName.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtOilName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOilName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOilName.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtOilName.Location = new System.Drawing.Point(16, 62);
            this.txtOilName.Size = new System.Drawing.Size(230, 27);
            this.txtOilName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOilName_KeyUp);
            this.txtOilName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOilName_KeyDown);
            // 
            // txtPrice
            // 
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtPrice.Location = new System.Drawing.Point(262, 62);
            this.txtPrice.Size = new System.Drawing.Size(100, 27);
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            // 
            // txtQunatity
            // 
            this.txtQunatity.Name = "txtQunatity";
            this.txtQunatity.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtQunatity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQunatity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQunatity.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtQunatity.Location = new System.Drawing.Point(378, 62);
            this.txtQunatity.Size = new System.Drawing.Size(100, 27);
            this.txtQunatity.Leave += new System.EventHandler(this.txtQunatity_Leave);
            this.txtQunatity.TextChanged += new System.EventHandler(this.txtQunatity_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtTotal.Location = new System.Drawing.Point(494, 62);
            this.txtTotal.Size = new System.Drawing.Size(110, 27);
            this.txtTotal.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAdd.Location = new System.Drawing.Point(622, 60);
            this.btnAdd.Size = new System.Drawing.Size(150, 31);
            this.btnAdd.Text = "Add to order";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Size = new System.Drawing.Size(340, 632);
            // 
            // lblSummary
            // 
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            this.lblSummary.Location = new System.Drawing.Point(24, 20);
            this.lblSummary.Text = "Order summary";
            // 
            // lblOid
            // 
            this.lblOid.Name = "lblOid";
            this.lblOid.AutoSize = true;
            this.lblOid.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOid.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblOid.Location = new System.Drawing.Point(24, 64);
            this.lblOid.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtOrderID.Location = new System.Drawing.Point(24, 86);
            this.txtOrderID.Size = new System.Drawing.Size(292, 27);
            this.txtOrderID.ReadOnly = true;
            // 
            // lblPay
            // 
            this.lblPay.Name = "lblPay";
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPay.Location = new System.Drawing.Point(24, 128);
            this.lblPay.Text = "Payment type";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaymentType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Mobile Banking"});
            this.cmbPaymentType.Location = new System.Drawing.Point(24, 150);
            this.cmbPaymentType.Size = new System.Drawing.Size(292, 28);
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblDate.Location = new System.Drawing.Point(24, 192);
            this.lblDate.Text = "Purchase date";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.CustomFormat = "yyyy-MM-dd";
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(24, 214);
            this.dtpPurchaseDate.Size = new System.Drawing.Size(292, 27);
            // 
            // pnlLine
            // 
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlLine.Location = new System.Drawing.Point(24, 262);
            this.pnlLine.Size = new System.Drawing.Size(292, 1);
            // 
            // lblGrand
            // 
            this.lblGrand.Name = "lblGrand";
            this.lblGrand.AutoSize = true;
            this.lblGrand.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrand.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblGrand.Location = new System.Drawing.Point(24, 278);
            this.lblGrand.Text = "Grand total";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrandTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtGrandTotal.Location = new System.Drawing.Point(24, 300);
            this.txtGrandTotal.Size = new System.Drawing.Size(292, 27);
            this.txtGrandTotal.ReadOnly = true;
            // 
            // lblCash
            // 
            this.lblCash.Name = "lblCash";
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblCash.Location = new System.Drawing.Point(24, 360);
            this.lblCash.Text = "Cash received";
            // 
            // txtCash
            // 
            this.txtCash.Name = "txtCash";
            this.txtCash.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtCash.Location = new System.Drawing.Point(24, 382);
            this.txtCash.Size = new System.Drawing.Size(292, 27);
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // lblChange
            // 
            this.lblChange.Name = "lblChange";
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblChange.Location = new System.Drawing.Point(24, 428);
            this.lblChange.Text = "Change";
            // 
            // txtChange
            // 
            this.txtChange.Name = "txtChange";
            this.txtChange.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtChange.Location = new System.Drawing.Point(24, 450);
            this.txtChange.Size = new System.Drawing.Size(292, 27);
            this.txtChange.ReadOnly = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnConfirm.Location = new System.Drawing.Point(24, 554);
            this.btnConfirm.Size = new System.Drawing.Size(292, 54);
            this.btnConfirm.Text = "Confirm order";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(15, 42, 67);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(1180, 68);
            // 
            // lblTitle
            // 
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitle.Location = new System.Drawing.Point(28, 18);
            this.lblTitle.Text = "Sales Counter";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.AutoSize = false;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblUser.Location = new System.Drawing.Point(774, 20);
            this.lblUser.Text = "";
            this.lblUser.Size = new System.Drawing.Size(260, 28);
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            this.btnBack.Location = new System.Drawing.Point(1046, 16);
            this.btnBack.Size = new System.Drawing.Size(110, 36);
            this.btnBack.Text = "Logout";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.Controls.Add(this.listBoxProduct);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop);
            // pnlMain children
            this.pnlMain.Controls.Add(this.pnlCart);
            this.pnlMain.Controls.Add(this.pnlSpacer);
            this.pnlMain.Controls.Add(this.pnlItem);
            // pnlCart children
            this.pnlCart.Controls.Add(this.dgvOrder);
            this.pnlCart.Controls.Add(this.pnlCartBottom);
            this.pnlCart.Controls.Add(this.pnlCartTop);
            // pnlCartBottom children
            this.pnlCartBottom.Controls.Add(this.btnDelete);
            // pnlCartTop children
            this.pnlCartTop.Controls.Add(this.lblCartTitle);
            // pnlItem children
            this.pnlItem.Controls.Add(this.lblItemTitle);
            this.pnlItem.Controls.Add(this.lblO);
            this.pnlItem.Controls.Add(this.lblP);
            this.pnlItem.Controls.Add(this.lblQ);
            this.pnlItem.Controls.Add(this.lblT);
            this.pnlItem.Controls.Add(this.txtOilName);
            this.pnlItem.Controls.Add(this.txtPrice);
            this.pnlItem.Controls.Add(this.txtQunatity);
            this.pnlItem.Controls.Add(this.txtTotal);
            this.pnlItem.Controls.Add(this.btnAdd);
            // pnlRight children
            this.pnlRight.Controls.Add(this.lblSummary);
            this.pnlRight.Controls.Add(this.lblOid);
            this.pnlRight.Controls.Add(this.txtOrderID);
            this.pnlRight.Controls.Add(this.lblPay);
            this.pnlRight.Controls.Add(this.cmbPaymentType);
            this.pnlRight.Controls.Add(this.lblDate);
            this.pnlRight.Controls.Add(this.dtpPurchaseDate);
            this.pnlRight.Controls.Add(this.pnlLine);
            this.pnlRight.Controls.Add(this.lblGrand);
            this.pnlRight.Controls.Add(this.txtGrandTotal);
            this.pnlRight.Controls.Add(this.lblCash);
            this.pnlRight.Controls.Add(this.txtCash);
            this.pnlRight.Controls.Add(this.lblChange);
            this.pnlRight.Controls.Add(this.txtChange);
            this.pnlRight.Controls.Add(this.btnConfirm);
            // pnlTop children
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblUser);
            this.pnlTop.Controls.Add(this.btnBack);
            // 
            // FormSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1180, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormSalesman";
            this.Text = "ARA Petrol Pump - Sales Counter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormSalesman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlCart.ResumeLayout(false);
            this.pnlCartBottom.ResumeLayout(false);
            this.pnlCartTop.ResumeLayout(false);
            this.pnlSpacer.ResumeLayout(false);
            this.pnlItem.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlLine.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Panel pnlCartBottom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlCartTop;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.Panel pnlSpacer;
        private System.Windows.Forms.Panel pnlItem;
        private System.Windows.Forms.Label lblItemTitle;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.TextBox txtOilName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQunatity;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblOid;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Label lblGrand;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnBack;
    }
}
