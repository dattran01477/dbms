namespace MilkTea_app
{
    partial class Users
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelText = new System.Windows.Forms.Panel();
            this.btnHuy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLuu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            this.txtPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtUsername = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblQuyen = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.panelButton.SuspendLayout();
            this.panelText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelButton.Controls.Add(this.btnXoa);
            this.panelButton.Controls.Add(this.btnCapnhat);
            this.panelButton.Controls.Add(this.btnSua);
            this.panelButton.Controls.Add(this.btnThem);
            this.panelButton.Location = new System.Drawing.Point(704, 2);
            this.panelButton.Margin = new System.Windows.Forms.Padding(2);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(234, 484);
            this.panelButton.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(58, 249);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 43);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.btnCapnhat.FlatAppearance.BorderSize = 0;
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapnhat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(58, 171);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(117, 43);
            this.btnCapnhat.TabIndex = 0;
            this.btnCapnhat.Text = "Cập Nhât";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(58, 100);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 43);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(58, 28);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelText
            // 
            this.panelText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelText.Controls.Add(this.btnHuy);
            this.panelText.Controls.Add(this.btnLuu);
            this.panelText.Controls.Add(this.cmbQuyen);
            this.panelText.Controls.Add(this.txtPassword);
            this.panelText.Controls.Add(this.txtUsername);
            this.panelText.Controls.Add(this.lblQuyen);
            this.panelText.Controls.Add(this.lblPass);
            this.panelText.Controls.Add(this.lblUsername);
            this.panelText.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelText.Location = new System.Drawing.Point(341, 2);
            this.panelText.Margin = new System.Windows.Forms.Padding(2);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(359, 484);
            this.panelText.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.ActiveBorderThickness = 1;
            this.btnHuy.ActiveCornerRadius = 20;
            this.btnHuy.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnHuy.ActiveForecolor = System.Drawing.Color.White;
            this.btnHuy.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnHuy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.ButtonText = "Hủy";
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.IdleBorderThickness = 1;
            this.btnHuy.IdleCornerRadius = 20;
            this.btnHuy.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(207)))));
            this.btnHuy.IdleForecolor = System.Drawing.Color.White;
            this.btnHuy.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(207)))));
            this.btnHuy.Location = new System.Drawing.Point(176, 427);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(107, 41);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ActiveBorderThickness = 1;
            this.btnLuu.ActiveCornerRadius = 20;
            this.btnLuu.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.ActiveForecolor = System.Drawing.Color.White;
            this.btnLuu.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.IdleBorderThickness = 1;
            this.btnLuu.IdleCornerRadius = 20;
            this.btnLuu.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(207)))));
            this.btnLuu.IdleForecolor = System.Drawing.Color.White;
            this.btnLuu.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(140)))), ((int)(((byte)(207)))));
            this.btnLuu.Location = new System.Drawing.Point(42, 427);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 41);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.Location = new System.Drawing.Point(152, 154);
            this.cmbQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(188, 25);
            this.cmbQuyen.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(152, 100);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(188, 25);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsername.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(152, 42);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(188, 25);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Location = new System.Drawing.Point(15, 161);
            this.lblQuyen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(94, 18);
            this.lblQuyen.TabIndex = 1;
            this.lblQuyen.Text = "Phân quyền";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(15, 107);
            this.lblPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(75, 18);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 49);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 18);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(3, 3);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(333, 482);
            this.dgvUser.TabIndex = 5;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelButton);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(940, 488);
            this.panelButton.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelText;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHuy;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLuu;
        private System.Windows.Forms.ComboBox cmbQuyen;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtPassword;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQuyen;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPass;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsername;
        private System.Windows.Forms.DataGridView dgvUser;
    }
}
