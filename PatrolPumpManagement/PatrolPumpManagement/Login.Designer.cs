namespace PatrolPumpManagement
{
    partial class Login
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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.pnlAccent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlCard.Location = new System.Drawing.Point(270, 100);
            this.pnlCard.Size = new System.Drawing.Size(420, 440);
            // 
            // pnlAccent
            // 
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.pnlAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAccent.Size = new System.Drawing.Size(420, 6);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.AutoSize = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(15, 42, 67);
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Text = "ARA Petrol Pump Station";
            this.label1.Size = new System.Drawing.Size(420, 40);
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSub
            // 
            this.lblSub.Name = "lblSub";
            this.lblSub.AutoSize = false;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSub.Location = new System.Drawing.Point(0, 76);
            this.lblSub.Text = "Sign in to your account";
            this.lblSub.Size = new System.Drawing.Size(420, 24);
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Text = "User ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtUserId.Location = new System.Drawing.Point(40, 150);
            this.txtUserId.Size = new System.Drawing.Size(340, 27);
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.label3.Location = new System.Drawing.Point(40, 200);
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtPassword.Location = new System.Drawing.Point(40, 222);
            this.txtPassword.Size = new System.Drawing.Size(262, 27);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // button1
            // 
            this.button1.Name = "button1";
            this.button1.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.button1.Location = new System.Drawing.Point(312, 221);
            this.button1.Size = new System.Drawing.Size(68, 29);
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(15, 42, 67);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLogin.Location = new System.Drawing.Point(40, 284);
            this.btnLogin.Size = new System.Drawing.Size(340, 46);
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Name = "btnClear";
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnClear.Location = new System.Drawing.Point(40, 340);
            this.btnClear.Size = new System.Drawing.Size(340, 34);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.AutoSize = false;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblFooter.Location = new System.Drawing.Point(0, 396);
            this.lblFooter.Text = "Managers and salesmen sign in here";
            this.lblFooter.Size = new System.Drawing.Size(420, 22);
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.pnlCard);
            // pnlCard children
            this.pnlCard.Controls.Add(this.pnlAccent);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.lblSub);
            this.pnlCard.Controls.Add(this.label2);
            this.pnlCard.Controls.Add(this.txtUserId);
            this.pnlCard.Controls.Add(this.label3);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.button1);
            this.pnlCard.Controls.Add(this.btnLogin);
            this.pnlCard.Controls.Add(this.btnClear);
            this.pnlCard.Controls.Add(this.lblFooter);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(15, 42, 67);
            this.ClientSize = new System.Drawing.Size(961, 643);
            this.MinimumSize = new System.Drawing.Size(720, 560);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Text = "ARA Petrol Pump - Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AcceptButton = this.btnLogin;
            this.BackgroundImage = global::PatrolPumpManagement.Properties.Resources.ara_Petrol_Station;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Load += new System.EventHandler(this.btnClear_Click);
            this.pnlCard.ResumeLayout(false);
            this.pnlAccent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFooter;
    }
}
