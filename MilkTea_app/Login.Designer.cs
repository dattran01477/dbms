namespace MilkTea_app
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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckIsManager = new System.Windows.Forms.CheckBox();
            this.ckIsEmployee = new System.Windows.Forms.CheckBox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.ckIsManager);
            this.panel1.Controls.Add(this.ckIsEmployee);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnLogo);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 332);
            this.panel1.TabIndex = 0;
            // 
            // ckIsManager
            // 
            this.ckIsManager.AutoSize = true;
            this.ckIsManager.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ckIsManager.Location = new System.Drawing.Point(472, 220);
            this.ckIsManager.Name = "ckIsManager";
            this.ckIsManager.Size = new System.Drawing.Size(98, 24);
            this.ckIsManager.TabIndex = 1;
            this.ckIsManager.Text = "manager";
            this.ckIsManager.UseVisualStyleBackColor = true;
            this.ckIsManager.CheckedChanged += new System.EventHandler(this.ckIsManager_CheckedChanged);
            // 
            // ckIsEmployee
            // 
            this.ckIsEmployee.AutoSize = true;
            this.ckIsEmployee.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ckIsEmployee.Location = new System.Drawing.Point(301, 220);
            this.ckIsEmployee.Name = "ckIsEmployee";
            this.ckIsEmployee.Size = new System.Drawing.Size(105, 24);
            this.ckIsEmployee.TabIndex = 2;
            this.ckIsEmployee.Text = "employee";
            this.ckIsEmployee.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.LightGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.LightCyan;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.IdleForecolor = System.Drawing.Color.LightCyan;
            this.btnLogin.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.Location = new System.Drawing.Point(336, 262);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(189, 41);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(233, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "PassWord:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(233, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "UserName:";
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogo.Controls.Add(this.label1);
            this.pnLogo.Controls.Add(this.pictureBox1);
            this.pnLogo.Location = new System.Drawing.Point(13, 15);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(179, 166);
            this.pnLogo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "The Best Of Milk Tea";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MilkTea_app.Properties.Resources.logo21;
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtPass.HintText = "";
            this.txtPass.isPassword = true;
            this.txtPass.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPass.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtPass.LineThickness = 2;
            this.txtPass.Location = new System.Drawing.Point(336, 160);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(306, 33);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Pass";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(336, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(306, 33);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 332);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckIsManager;
        private System.Windows.Forms.CheckBox ckIsEmployee;
    }
}