namespace MilkTea_app
{
    partial class TaiKhoang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoang));
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMKcu = new System.Windows.Forms.Label();
            this.txtMKmoi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMKcu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMKmoi2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnXacnhan = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.button5.BackgroundImage = global::MilkTea_app.Properties.Resources.cancel;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(356, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // lblMKcu
            // 
            this.lblMKcu.AutoSize = true;
            this.lblMKcu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMKcu.Location = new System.Drawing.Point(36, 59);
            this.lblMKcu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMKcu.Name = "lblMKcu";
            this.lblMKcu.Size = new System.Drawing.Size(94, 16);
            this.lblMKcu.TabIndex = 14;
            this.lblMKcu.Text = "Mật khẩu cũ:";
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKmoi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMKmoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMKmoi.HintForeColor = System.Drawing.Color.Empty;
            this.txtMKmoi.HintText = "";
            this.txtMKmoi.isPassword = true;
            this.txtMKmoi.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtMKmoi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMKmoi.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtMKmoi.LineThickness = 2;
            this.txtMKmoi.Location = new System.Drawing.Point(136, 86);
            this.txtMKmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(230, 27);
            this.txtMKmoi.TabIndex = 11;
            this.txtMKmoi.Text = "123";
            this.txtMKmoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMKcu
            // 
            this.txtMKcu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKcu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMKcu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMKcu.HintForeColor = System.Drawing.Color.Empty;
            this.txtMKcu.HintText = "";
            this.txtMKcu.isPassword = false;
            this.txtMKcu.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtMKcu.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMKcu.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtMKcu.LineThickness = 3;
            this.txtMKcu.Location = new System.Drawing.Point(136, 49);
            this.txtMKcu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(230, 27);
            this.txtMKcu.TabIndex = 12;
            this.txtMKcu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMKcu.OnValueChanged += new System.EventHandler(this.txtMKcu_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Xác nhận MK";
            // 
            // txtMKmoi2
            // 
            this.txtMKmoi2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKmoi2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMKmoi2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMKmoi2.HintForeColor = System.Drawing.Color.Empty;
            this.txtMKmoi2.HintText = "";
            this.txtMKmoi2.isPassword = true;
            this.txtMKmoi2.LineFocusedColor = System.Drawing.Color.DimGray;
            this.txtMKmoi2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMKmoi2.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.txtMKmoi2.LineThickness = 2;
            this.txtMKmoi2.Location = new System.Drawing.Point(136, 127);
            this.txtMKmoi2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKmoi2.Name = "txtMKmoi2";
            this.txtMKmoi2.Size = new System.Drawing.Size(230, 27);
            this.txtMKmoi2.TabIndex = 15;
            this.txtMKmoi2.Text = "123";
            this.txtMKmoi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.ActiveBorderThickness = 1;
            this.btnXacnhan.ActiveCornerRadius = 20;
            this.btnXacnhan.ActiveFillColor = System.Drawing.Color.LightGreen;
            this.btnXacnhan.ActiveForecolor = System.Drawing.Color.White;
            this.btnXacnhan.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnXacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnXacnhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXacnhan.BackgroundImage")));
            this.btnXacnhan.ButtonText = "Xác nhận";
            this.btnXacnhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacnhan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacnhan.ForeColor = System.Drawing.Color.LightCyan;
            this.btnXacnhan.IdleBorderThickness = 1;
            this.btnXacnhan.IdleCornerRadius = 20;
            this.btnXacnhan.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnXacnhan.IdleForecolor = System.Drawing.Color.LightCyan;
            this.btnXacnhan.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.btnXacnhan.Location = new System.Drawing.Point(125, 173);
            this.btnXacnhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(142, 33);
            this.btnXacnhan.TabIndex = 17;
            this.btnXacnhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // TaiKhoang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(397, 219);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMKmoi2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMKcu);
            this.Controls.Add(this.txtMKmoi);
            this.Controls.Add(this.txtMKcu);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaiKhoang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMKcu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMKmoi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMKcu;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMKmoi2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXacnhan;
    }
}