namespace MilkTea_app
{
    partial class AppMilkTea
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMilkTea));
            this.pnTopBar = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDGV = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.animator1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnQuanLyTaiKhoang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThongKe = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnQuanLy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOrder = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnTopBar.SuspendLayout();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTopBar
            // 
            this.pnTopBar.AutoScroll = true;
            this.pnTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnTopBar.Controls.Add(this.btnQuanLyTaiKhoang);
            this.pnTopBar.Controls.Add(this.lbName);
            this.pnTopBar.Controls.Add(this.btnLogout);
            this.pnTopBar.Controls.Add(this.label2);
            this.pnTopBar.Controls.Add(this.btnThongKe);
            this.pnTopBar.Controls.Add(this.btnQuanLy);
            this.pnTopBar.Controls.Add(this.btnOrder);
            this.pnTopBar.Controls.Add(this.button5);
            this.pnTopBar.Controls.Add(this.pnLogo);
            this.animator2.SetDecoration(this.pnTopBar, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pnTopBar, BunifuAnimatorNS.DecorationType.None);
            this.pnTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnTopBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnTopBar.Name = "pnTopBar";
            this.pnTopBar.Size = new System.Drawing.Size(1375, 189);
            this.pnTopBar.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.animator1.SetDecoration(this.lbName, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.lbName, BunifuAnimatorNS.DecorationType.None);
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(909, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 19);
            this.lbName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.animator1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(233, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 186);
            this.label2.TabIndex = 8;
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogo.Controls.Add(this.label1);
            this.pnLogo.Controls.Add(this.pictureBox1);
            this.animator2.SetDecoration(this.pnLogo, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pnLogo, BunifuAnimatorNS.DecorationType.None);
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(232, 189);
            this.pnLogo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "The Best Of Milk Tea";
            // 
            // pnDGV
            // 
            this.animator2.SetDecoration(this.pnDGV, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pnDGV, BunifuAnimatorNS.DecorationType.None);
            this.pnDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDGV.Location = new System.Drawing.Point(0, 189);
            this.pnDGV.Name = "pnDGV";
            this.pnDGV.Size = new System.Drawing.Size(1375, 549);
            this.pnDGV.TabIndex = 2;
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animator1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation2;
            // 
            // animator2
            // 
            this.animator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animator2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator2.DefaultAnimation = animation1;
            // 
            // btnQuanLyTaiKhoang
            // 
            this.btnQuanLyTaiKhoang.ActiveBorderThickness = 1;
            this.btnQuanLyTaiKhoang.ActiveCornerRadius = 20;
            this.btnQuanLyTaiKhoang.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnQuanLyTaiKhoang.ActiveForecolor = System.Drawing.Color.White;
            this.btnQuanLyTaiKhoang.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnQuanLyTaiKhoang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuanLyTaiKhoang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnQuanLyTaiKhoang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyTaiKhoang.BackgroundImage")));
            this.btnQuanLyTaiKhoang.ButtonText = "Tài Khoản";
            this.btnQuanLyTaiKhoang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.btnQuanLyTaiKhoang, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.btnQuanLyTaiKhoang, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLyTaiKhoang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoang.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnQuanLyTaiKhoang.IdleBorderThickness = 1;
            this.btnQuanLyTaiKhoang.IdleCornerRadius = 20;
            this.btnQuanLyTaiKhoang.IdleFillColor = System.Drawing.Color.White;
            this.btnQuanLyTaiKhoang.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnQuanLyTaiKhoang.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnQuanLyTaiKhoang.Location = new System.Drawing.Point(1165, 47);
            this.btnQuanLyTaiKhoang.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuanLyTaiKhoang.Name = "btnQuanLyTaiKhoang";
            this.btnQuanLyTaiKhoang.Size = new System.Drawing.Size(124, 41);
            this.btnQuanLyTaiKhoang.TabIndex = 11;
            this.btnQuanLyTaiKhoang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanLyTaiKhoang.Click += new System.EventHandler(this.btnQuanLyTaiKhoang_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveBorderThickness = 1;
            this.btnLogout.ActiveCornerRadius = 20;
            this.btnLogout.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogout.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogout.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.ButtonText = "Đăng Xuất";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleCornerRadius = 20;
            this.btnLogout.IdleFillColor = System.Drawing.Color.White;
            this.btnLogout.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogout.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogout.Location = new System.Drawing.Point(1165, 5);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 41);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.ActiveBorderThickness = 1;
            this.btnThongKe.ActiveCornerRadius = 20;
            this.btnThongKe.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnThongKe.ActiveForecolor = System.Drawing.Color.White;
            this.btnThongKe.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnThongKe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThongKe.BackgroundImage")));
            this.btnThongKe.ButtonText = "Thống Kê";
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.btnThongKe, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.btnThongKe, BunifuAnimatorNS.DecorationType.None);
            this.btnThongKe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThongKe.IdleBorderThickness = 1;
            this.btnThongKe.IdleCornerRadius = 20;
            this.btnThongKe.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnThongKe.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnThongKe.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnThongKe.Location = new System.Drawing.Point(810, 148);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(208, 41);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.ActiveBorderThickness = 1;
            this.btnQuanLy.ActiveCornerRadius = 20;
            this.btnQuanLy.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnQuanLy.ActiveForecolor = System.Drawing.Color.White;
            this.btnQuanLy.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnQuanLy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuanLy.BackgroundImage")));
            this.btnQuanLy.ButtonText = "Quản Lý";
            this.btnQuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.btnQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.btnQuanLy, BunifuAnimatorNS.DecorationType.None);
            this.btnQuanLy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnQuanLy.IdleBorderThickness = 1;
            this.btnQuanLy.IdleCornerRadius = 20;
            this.btnQuanLy.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnQuanLy.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnQuanLy.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnQuanLy.Location = new System.Drawing.Point(583, 148);
            this.btnQuanLy.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(208, 41);
            this.btnQuanLy.TabIndex = 6;
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.ActiveBorderThickness = 1;
            this.btnOrder.ActiveCornerRadius = 20;
            this.btnOrder.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOrder.ActiveForecolor = System.Drawing.Color.White;
            this.btnOrder.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.BackgroundImage")));
            this.btnOrder.ButtonText = "Order";
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.btnOrder, BunifuAnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.btnOrder, BunifuAnimatorNS.DecorationType.None);
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOrder.IdleBorderThickness = 1;
            this.btnOrder.IdleCornerRadius = 20;
            this.btnOrder.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnOrder.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOrder.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOrder.Location = new System.Drawing.Point(356, 148);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(208, 41);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrder.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.button5.BackgroundImage = global::MilkTea_app.Properties.Resources.cancel;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1345, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.animator1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::MilkTea_app.Properties.Resources.logo21;
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AppMilkTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1375, 738);
            this.Controls.Add(this.pnDGV);
            this.Controls.Add(this.pnTopBar);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("MS Reference Specialty", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AppMilkTea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trà Sữa Di&Pi";
            this.pnTopBar.ResumeLayout(false);
            this.pnTopBar.PerformLayout();
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTopBar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnDGV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThongKe;
        private Bunifu.Framework.UI.BunifuThinButton2 btnQuanLy;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition animator1;
        private BunifuAnimatorNS.BunifuTransition animator2;
        private System.Windows.Forms.Label lbName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogout;
        private Bunifu.Framework.UI.BunifuThinButton2 btnQuanLyTaiKhoang;
    }
}

