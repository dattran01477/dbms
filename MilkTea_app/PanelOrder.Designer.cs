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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlOder = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnBtnProducts = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnOrderDrinks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrder)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.gridControlOder);
            this.panel1.Controls.Add(this.pnBtnProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 448);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gridControlOder
            // 
            this.gridControlOder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOder.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControlOder.Location = new System.Drawing.Point(0, 0);
            this.gridControlOder.MainView = this.gridViewOrder;
            this.gridControlOder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControlOder.Name = "gridControlOder";
            this.gridControlOder.Size = new System.Drawing.Size(600, 244);
            this.gridControlOder.TabIndex = 1;
            this.gridControlOder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrder});
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
            this.name.AppearanceCell.Options.UseTextOptions = true;
            this.name.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.name.AppearanceHeader.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.AppearanceHeader.Options.UseFont = true;
            this.name.Caption = "Name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            // 
            // amount
            // 
            this.amount.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.AppearanceCell.Options.UseFont = true;
            this.amount.Caption = "Amount";
            this.amount.FieldName = "amount";
            this.amount.Name = "amount";
            this.amount.Visible = true;
            this.amount.VisibleIndex = 1;
            // 
            // price
            // 
            this.price.AppearanceCell.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.AppearanceCell.Options.UseFont = true;
            this.price.Caption = "Price";
            this.price.FieldName = "price";
            this.price.Name = "price";
            this.price.Visible = true;
            this.price.VisibleIndex = 2;
            // 
            // pnBtnProducts
            // 
            this.pnBtnProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBtnProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBtnProducts.Location = new System.Drawing.Point(0, 244);
            this.pnBtnProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnBtnProducts.Name = "pnBtnProducts";
            this.pnBtnProducts.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.pnBtnProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnBtnProducts.Size = new System.Drawing.Size(600, 204);
            this.pnBtnProducts.TabIndex = 0;
            this.pnBtnProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBtnProducts_Paint);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnMenu.Controls.Add(this.txtSum);
            this.pnMenu.Controls.Add(this.btnOrderDrinks);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMenu.Location = new System.Drawing.Point(599, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(156, 448);
            this.pnMenu.TabIndex = 1;
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(52, 344);
            this.txtSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(103, 19);
            this.txtSum.TabIndex = 2;
            // 
            // btnOrderDrinks
            // 
            this.btnOrderDrinks.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnOrderDrinks.FlatAppearance.BorderSize = 2;
            this.btnOrderDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderDrinks.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDrinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.btnOrderDrinks.Image = global::MilkTea_app.Properties.Resources.tray__1_;
            this.btnOrderDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDrinks.Location = new System.Drawing.Point(-4, 395);
            this.btnOrderDrinks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderDrinks.Name = "btnOrderDrinks";
            this.btnOrderDrinks.Size = new System.Drawing.Size(160, 50);
            this.btnOrderDrinks.TabIndex = 1;
            this.btnOrderDrinks.Text = "Thanh Toán";
            this.btnOrderDrinks.UseCompatibleTextRendering = true;
            this.btnOrderDrinks.UseVisualStyleBackColor = true;
            this.btnOrderDrinks.Click += new System.EventHandler(this.btnOrderDrinks_Click);
            // 
            // PanelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PanelOrder";
            this.Size = new System.Drawing.Size(755, 448);
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
        private System.Windows.Forms.Panel pnBtnProducts;
        private System.Windows.Forms.Button btnOrderDrinks;
        private DevExpress.XtraGrid.GridControl gridControlOder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrder;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn amount;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private System.Windows.Forms.TextBox txtSum;
    }
}
