namespace MilkTea_app
{
    partial class PanelOrder
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPnBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.gridControlOder = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDisCount = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnOrderDrinks = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.flowLayoutPnBtn);
            this.panel1.Controls.Add(this.gridControlOder);
            this.panel1.Controls.Add(this.pnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 468);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPnBtn
            // 
            this.flowLayoutPnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPnBtn.AutoScroll = true;
            this.flowLayoutPnBtn.AutoScrollMargin = new System.Drawing.Size(12, 59);
            this.flowLayoutPnBtn.AutoScrollMinSize = new System.Drawing.Size(12, 59);
            this.flowLayoutPnBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPnBtn.Location = new System.Drawing.Point(0, 228);
            this.flowLayoutPnBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPnBtn.Name = "flowLayoutPnBtn";
            this.flowLayoutPnBtn.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.flowLayoutPnBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPnBtn.Size = new System.Drawing.Size(624, 240);
            this.flowLayoutPnBtn.TabIndex = 0;
            // 
            // gridControlOder
            // 
            this.gridControlOder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControlOder.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlOder.Location = new System.Drawing.Point(0, 0);
            this.gridControlOder.MainView = this.gridViewOrder;
            this.gridControlOder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControlOder.Name = "gridControlOder";
            this.gridControlOder.Size = new System.Drawing.Size(624, 232);
            this.gridControlOder.TabIndex = 5;
            this.gridControlOder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrder});
            this.gridControlOder.Click += new System.EventHandler(this.gridControlOder_Click_1);
            // 
            // gridViewOrder
            // 
            this.gridViewOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.name,
            this.amount,
            this.price});
            this.gridViewOrder.GridControl = this.gridControlOder;
            this.gridViewOrder.Name = "gridViewOrder";
            this.gridViewOrder.RowHeight = 20;
            // 
            // name
            // 
            this.name.AppearanceCell.Options.UseFont = true;
            this.name.AppearanceCell.Options.UseTextOptions = true;
            this.name.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.name.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.name.AppearanceHeader.Options.UseFont = true;
            this.name.Caption = "Name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            // 
            // amount
            // 
            this.amount.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.amount.AppearanceCell.Options.UseFont = true;
            this.amount.Caption = "Amount";
            this.amount.FieldName = "amount";
            this.amount.Name = "amount";
            this.amount.OptionsColumn.AllowEdit = false;
            this.amount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            // 
            // price
            // 
            this.price.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.price.AppearanceCell.Options.UseFont = true;
            this.price.Caption = "Price";
            this.price.FieldName = "price";
            this.price.Name = "price";
            this.price.OptionsColumn.AllowEdit = false;
            this.price.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.price.Visible = true;
            this.price.VisibleIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnMenu.Controls.Add(this.btnXoa);
            this.pnMenu.Controls.Add(this.label2);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.bunifuCustomLabel4);
            this.pnMenu.Controls.Add(this.txtDisCount);
            this.pnMenu.Controls.Add(this.bunifuCustomLabel3);
            this.pnMenu.Controls.Add(this.bunifuCustomLabel2);
            this.pnMenu.Controls.Add(this.bunifuCustomLabel1);
            this.pnMenu.Controls.Add(this.txtSum);
            this.pnMenu.Controls.Add(this.btnOrderDrinks);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMenu.Location = new System.Drawing.Point(624, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(179, 468);
            this.pnMenu.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DimGray;
            this.btnXoa.Image = global::MilkTea_app.Properties.Resources.tray__1_;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(35, 3);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 41);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa Món";
            this.btnXoa.UseCompatibleTextRendering = true;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 3);
            this.label2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 3);
            this.label1.TabIndex = 8;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(151, 210);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(26, 27);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "%";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDisCount
            // 
            this.txtDisCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisCount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtDisCount.Location = new System.Drawing.Point(103, 210);
            this.txtDisCount.Name = "txtDisCount";
            this.txtDisCount.Size = new System.Drawing.Size(48, 30);
            this.txtDisCount.TabIndex = 5;
            this.txtDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisCount.TextChanged += new System.EventHandler(this.txtDisCount_TextChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 188);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(94, 70);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "DisCount";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(117, 362);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(64, 27);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "VND";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1, 287);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(167, 70);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Tổng tiền thanh toán";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSum.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtSum.Location = new System.Drawing.Point(4, 360);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(108, 30);
            this.txtSum.TabIndex = 2;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOrderDrinks
            // 
            this.btnOrderDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.btnOrderDrinks.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnOrderDrinks.FlatAppearance.BorderSize = 0;
            this.btnOrderDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDrinks.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDrinks.ForeColor = System.Drawing.Color.White;
            this.btnOrderDrinks.Image = global::MilkTea_app.Properties.Resources.tray__1_;
            this.btnOrderDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDrinks.Location = new System.Drawing.Point(31, 410);
            this.btnOrderDrinks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrderDrinks.Name = "btnOrderDrinks";
            this.btnOrderDrinks.Size = new System.Drawing.Size(133, 41);
            this.btnOrderDrinks.TabIndex = 1;
            this.btnOrderDrinks.Text = "   Thanh Toán";
            this.btnOrderDrinks.UseCompatibleTextRendering = true;
            this.btnOrderDrinks.UseVisualStyleBackColor = false;
            this.btnOrderDrinks.Click += new System.EventHandler(this.btnOrderDrinks_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.btnOrderDrinks;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.btnXoa;
            // 
            // PanelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PanelOrder";
            this.Size = new System.Drawing.Size(803, 468);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnOrderDrinks;
        private System.Windows.Forms.TextBox txtSum;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txtDisCount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlOder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrder;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn amount;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPnBtn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}
