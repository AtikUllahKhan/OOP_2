namespace PatrolPumpManagement
{
    partial class FormSmAdd
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
            System.Windows.Forms.DataGridViewCellStyle dgvSalesManHead = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvSalesManCell = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvSalesManAlt = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvSalesMan = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlFormCard = new System.Windows.Forms.Panel();
            this.lblSec1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblJoin = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.lblSec2 = new System.Windows.Forms.Label();
            this.lblUserN = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPw = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesMan)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // dgvSalesManHead
            dgvSalesManHead.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvSalesManHead.BackColor = System.Drawing.Color.FromArgb(15, 42, 67);
            dgvSalesManHead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvSalesManHead.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvSalesManHead.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgvSalesManHead.SelectionBackColor = System.Drawing.Color.FromArgb(15, 42, 67);
            dgvSalesManHead.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvSalesManHead.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            // dgvSalesManCell
            dgvSalesManCell.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvSalesManCell.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dgvSalesManCell.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvSalesManCell.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvSalesManCell.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgvSalesManCell.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dgvSalesManCell.SelectionForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            dgvSalesManCell.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            // dgvSalesManAlt
            dgvSalesManAlt.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvSalesManAlt.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dgvSalesManAlt.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dgvSalesManAlt.SelectionForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(24, 0, 24, 24);
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // dgvSalesMan
            // 
            this.dgvSalesMan.Name = "dgvSalesMan";
            this.dgvSalesMan.AllowUserToAddRows = false;
            this.dgvSalesMan.AllowUserToDeleteRows = false;
            this.dgvSalesMan.AllowUserToResizeRows = false;
            this.dgvSalesMan.AlternatingRowsDefaultCellStyle = dgvSalesManAlt;
            this.dgvSalesMan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesMan.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvSalesMan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalesMan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSalesMan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSalesMan.ColumnHeadersDefaultCellStyle = dgvSalesManHead;
            this.dgvSalesMan.ColumnHeadersHeight = 38;
            this.dgvSalesMan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesMan.DefaultCellStyle = dgvSalesManCell;
            this.dgvSalesMan.EnableHeadersVisualStyles = false;
            this.dgvSalesMan.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvSalesMan.MultiSelect = false;
            this.dgvSalesMan.ReadOnly = true;
            this.dgvSalesMan.RowHeadersVisible = false;
            this.dgvSalesMan.RowTemplate.Height = 34;
            this.dgvSalesMan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesMan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ID,
                this.NickName,
                this.PhoneNo,
                this.Salary,
                this.JoiningDate,
                this.UserType,
                this.Password});
            this.dgvSalesMan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesMan_CellClick);
            this.dgvSalesMan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSalesMan_CellFormatting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 16F;
            this.ID.HeaderText = "Username / ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NickName
            // 
            this.NickName.DataPropertyName = "Name";
            this.NickName.FillWeight = 22F;
            this.NickName.HeaderText = "Name";
            this.NickName.Name = "NickName";
            this.NickName.ReadOnly = true;
            // 
            // PhoneNo
            // 
            this.PhoneNo.DataPropertyName = "PhoneNo";
            this.PhoneNo.FillWeight = 18F;
            this.PhoneNo.HeaderText = "Phone";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.FillWeight = 12F;
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // JoiningDate
            // 
            this.JoiningDate.DataPropertyName = "JoiningDate";
            this.JoiningDate.FillWeight = 14F;
            this.JoiningDate.HeaderText = "Joined";
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
            // 
            // UserType
            // 
            this.UserType.DataPropertyName = "UserType";
            this.UserType.FillWeight = 12F;
            this.UserType.HeaderText = "Type";
            this.UserType.Name = "UserType";
            this.UserType.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.FillWeight = 12F;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
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
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Size = new System.Drawing.Size(100, 292);
            this.pnlForm.Padding = new System.Windows.Forms.Padding(24, 0, 24, 12);
            // 
            // pnlFormCard
            // 
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // lblSec1
            // 
            this.lblSec1.Name = "lblSec1";
            this.lblSec1.AutoSize = true;
            this.lblSec1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec1.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblSec1.Location = new System.Drawing.Point(20, 14);
            this.lblSec1.Text = "PERSONAL DETAILS";
            // 
            // lblName
            // 
            this.lblName.Name = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblName.Location = new System.Drawing.Point(20, 40);
            this.lblName.Text = "Name";
            // 
            // lblPhone
            // 
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPhone.Location = new System.Drawing.Point(225, 40);
            this.lblPhone.Text = "Phone";
            // 
            // lblSalary
            // 
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblSalary.Location = new System.Drawing.Point(430, 40);
            this.lblSalary.Text = "Salary (Tk)";
            // 
            // lblJoin
            // 
            this.lblJoin.Name = "lblJoin";
            this.lblJoin.AutoSize = true;
            this.lblJoin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoin.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblJoin.Location = new System.Drawing.Point(635, 40);
            this.lblJoin.Text = "Joining date";
            // 
            // txtName
            // 
            this.txtName.Name = "txtName";
            this.txtName.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtName.Location = new System.Drawing.Point(20, 62);
            this.txtName.Size = new System.Drawing.Size(190, 27);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNo.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtPhoneNo.Location = new System.Drawing.Point(225, 62);
            this.txtPhoneNo.Size = new System.Drawing.Size(190, 27);
            // 
            // txtSalary
            // 
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtSalary.Location = new System.Drawing.Point(430, 62);
            this.txtSalary.Size = new System.Drawing.Size(190, 27);
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoiningDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoiningDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoiningDate.Location = new System.Drawing.Point(635, 62);
            this.dtpJoiningDate.Size = new System.Drawing.Size(190, 27);
            // 
            // lblSec2
            // 
            this.lblSec2.Name = "lblSec2";
            this.lblSec2.AutoSize = true;
            this.lblSec2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec2.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblSec2.Location = new System.Drawing.Point(20, 110);
            this.lblSec2.Text = "LOGIN ACCOUNT  (created automatically - the salesman signs in with these)";
            // 
            // lblUserN
            // 
            this.lblUserN.Name = "lblUserN";
            this.lblUserN.AutoSize = true;
            this.lblUserN.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserN.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblUserN.Location = new System.Drawing.Point(20, 136);
            this.lblUserN.Text = "Username (Salesman ID)";
            // 
            // lblType
            // 
            this.lblType.Name = "lblType";
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblType.Location = new System.Drawing.Point(225, 136);
            this.lblType.Text = "User type";
            // 
            // lblPw
            // 
            this.lblPw.Name = "lblPw";
            this.lblPw.AutoSize = true;
            this.lblPw.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPw.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPw.Location = new System.Drawing.Point(430, 136);
            this.lblPw.Text = "Password";
            // 
            // txtID
            // 
            this.txtID.Name = "txtID";
            this.txtID.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtID.Location = new System.Drawing.Point(20, 158);
            this.txtID.Size = new System.Drawing.Size(190, 27);
            this.txtID.ReadOnly = true;
            // 
            // cmbUserType
            // 
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUserType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "salesman",
            "manager"});
            this.cmbUserType.Location = new System.Drawing.Point(225, 158);
            this.cmbUserType.Size = new System.Drawing.Size(190, 28);
            // 
            // txtPassword
            // 
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtPassword.Location = new System.Drawing.Point(430, 158);
            this.txtPassword.Size = new System.Drawing.Size(110, 27);
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnGeneratePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePassword.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnGeneratePassword.Location = new System.Drawing.Point(546, 157);
            this.btnGeneratePassword.Size = new System.Drawing.Size(74, 29);
            this.btnGeneratePassword.Text = "Generate";
            this.btnGeneratePassword.UseVisualStyleBackColor = false;
            this.btnGeneratePassword.FlatAppearance.BorderSize = 0;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.chkShowPassword.Location = new System.Drawing.Point(635, 161);
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAdd.Location = new System.Drawing.Point(20, 214);
            this.btnAdd.Size = new System.Drawing.Size(170, 40);
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
            this.btnDelete.Location = new System.Drawing.Point(200, 214);
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
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
            this.btnClear.Location = new System.Drawing.Point(330, 214);
            this.btnClear.Size = new System.Drawing.Size(110, 40);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.lblTitle.Text = "Salesmen";
            // 
            // lblSub
            // 
            this.lblSub.Name = "lblSub";
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSub.Location = new System.Drawing.Point(26, 46);
            this.lblSub.Text = "Create salesman accounts - the login username and password are made for you";
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            // pnlGrid children
            this.pnlGrid.Controls.Add(this.pnlGridCard);
            // pnlGridCard children
            this.pnlGridCard.Controls.Add(this.dgvSalesMan);
            this.pnlGridCard.Controls.Add(this.pnlSearch);
            // pnlSearch children
            this.pnlSearch.Controls.Add(this.txtAutoSearch);
            this.pnlSearch.Controls.Add(this.btnShowDetails);
            // pnlForm children
            this.pnlForm.Controls.Add(this.pnlFormCard);
            // pnlFormCard children
            this.pnlFormCard.Controls.Add(this.lblSec1);
            this.pnlFormCard.Controls.Add(this.lblName);
            this.pnlFormCard.Controls.Add(this.lblPhone);
            this.pnlFormCard.Controls.Add(this.lblSalary);
            this.pnlFormCard.Controls.Add(this.lblJoin);
            this.pnlFormCard.Controls.Add(this.txtName);
            this.pnlFormCard.Controls.Add(this.txtPhoneNo);
            this.pnlFormCard.Controls.Add(this.txtSalary);
            this.pnlFormCard.Controls.Add(this.dtpJoiningDate);
            this.pnlFormCard.Controls.Add(this.lblSec2);
            this.pnlFormCard.Controls.Add(this.lblUserN);
            this.pnlFormCard.Controls.Add(this.lblType);
            this.pnlFormCard.Controls.Add(this.lblPw);
            this.pnlFormCard.Controls.Add(this.txtID);
            this.pnlFormCard.Controls.Add(this.cmbUserType);
            this.pnlFormCard.Controls.Add(this.txtPassword);
            this.pnlFormCard.Controls.Add(this.btnGeneratePassword);
            this.pnlFormCard.Controls.Add(this.chkShowPassword);
            this.pnlFormCard.Controls.Add(this.btnAdd);
            this.pnlFormCard.Controls.Add(this.btnDelete);
            this.pnlFormCard.Controls.Add(this.btnClear);
            // pnlHeader children
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSub);
            // 
            // FormSmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormSmAdd";
            this.Text = "Salesmen";
            this.Load += new System.EventHandler(this.FormSmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesMan)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSalesMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.Label lblSec1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblJoin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.Label lblSec2;
        private System.Windows.Forms.Label lblUserN;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
    }
}
