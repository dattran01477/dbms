namespace MilkTea_app
{
    partial class Order
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
            this.panel2 = new System.Windows.Forms.Panel();
            
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.pnOrderTopping = new System.Windows.Forms.Panel();
            this.btnTopping = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.panelCategoryFoodOrder = new System.Windows.Forms.Panel();
            this.panelCategoryDrinkOrder = new System.Windows.Forms.Panel();
            this.btnOrderFood = new System.Windows.Forms.Button();
            this.btnOrderDrinks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.SideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.sidePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 553);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(237, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 553);
            this.panel2.TabIndex = 1;
          
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.SideBar);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(237, 553);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SideBar.Controls.Add(this.pnOrderTopping);
            this.SideBar.Controls.Add(this.btnTopping);
            this.SideBar.Controls.Add(this.label);
            this.SideBar.Controls.Add(this.panelCategoryFoodOrder);
            this.SideBar.Controls.Add(this.panelCategoryDrinkOrder);
            this.SideBar.Controls.Add(this.btnOrderFood);
            this.SideBar.Controls.Add(this.btnOrderDrinks);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(236, 553);
            this.SideBar.TabIndex = 1;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBar_Paint);
            // 
            // pnOrderTopping
            // 
            this.pnOrderTopping.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnOrderTopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.pnOrderTopping.Location = new System.Drawing.Point(27, 214);
            this.pnOrderTopping.Name = "pnOrderTopping";
            this.pnOrderTopping.Size = new System.Drawing.Size(182, 10);
            this.pnOrderTopping.TabIndex = 6;
            // 
            // btnTopping
            // 
            this.btnTopping.FlatAppearance.BorderSize = 0;
            this.btnTopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopping.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.btnTopping.Image = global::MilkTea_app.Properties.Resources.tray__1_;
            this.btnTopping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopping.Location = new System.Drawing.Point(2, 151);
            this.btnTopping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTopping.Name = "btnTopping";
            this.btnTopping.Size = new System.Drawing.Size(211, 62);
            this.btnTopping.TabIndex = 5;
            this.btnTopping.Text = "Topping";
            this.btnTopping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopping.UseVisualStyleBackColor = true;
            this.btnTopping.Click += new System.EventHandler(this.btnTopping_Click);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(178)))), ((int)(((byte)(183)))));
            this.label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(178)))), ((int)(((byte)(183)))));
            this.label.Location = new System.Drawing.Point(224, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(8, 62);
            this.label.TabIndex = 3;
            // 
            // panelCategoryFoodOrder
            // 
            this.panelCategoryFoodOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCategoryFoodOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.panelCategoryFoodOrder.Location = new System.Drawing.Point(23, 140);
            this.panelCategoryFoodOrder.Name = "panelCategoryFoodOrder";
            this.panelCategoryFoodOrder.Size = new System.Drawing.Size(182, 10);
            this.panelCategoryFoodOrder.TabIndex = 4;
            // 
            // panelCategoryDrinkOrder
            // 
            this.panelCategoryDrinkOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCategoryDrinkOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.panelCategoryDrinkOrder.Location = new System.Drawing.Point(24, 63);
            this.panelCategoryDrinkOrder.Name = "panelCategoryDrinkOrder";
            this.panelCategoryDrinkOrder.Size = new System.Drawing.Size(182, 13);
            this.panelCategoryDrinkOrder.TabIndex = 3;
            // 
            // btnOrderFood
            // 
            this.btnOrderFood.FlatAppearance.BorderSize = 0;
            this.btnOrderFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderFood.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnOrderFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.btnOrderFood.Image = global::MilkTea_app.Properties.Resources.tray__1_;
            this.btnOrderFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderFood.Location = new System.Drawing.Point(-2, 77);
            this.btnOrderFood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrderFood.Name = "btnOrderFood";
            this.btnOrderFood.Size = new System.Drawing.Size(211, 62);
            this.btnOrderFood.TabIndex = 2;
            this.btnOrderFood.Text = "Order Foods";
            this.btnOrderFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderFood.UseVisualStyleBackColor = true;
            this.btnOrderFood.Click += new System.EventHandler(this.btnOrderFood_Click);
            // 
            // btnOrderDrinks
            // 
            this.btnOrderDrinks.FlatAppearance.BorderSize = 0;
            this.btnOrderDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDrinks.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDrinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.btnOrderDrinks.Image = global::MilkTea_app.Properties.Resources.tray__1_;
            this.btnOrderDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDrinks.Location = new System.Drawing.Point(-2, 0);
            this.btnOrderDrinks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrderDrinks.Name = "btnOrderDrinks";
            this.btnOrderDrinks.Size = new System.Drawing.Size(211, 62);
            this.btnOrderDrinks.TabIndex = 0;
            this.btnOrderDrinks.Text = "Order Drinks";
            this.btnOrderDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderDrinks.UseVisualStyleBackColor = true;
            this.btnOrderDrinks.Click += new System.EventHandler(this.btnOrderDrinks_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1375, 553);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sidePanel1.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel pnOrderTopping;
        private System.Windows.Forms.Button btnTopping;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panelCategoryFoodOrder;
        private System.Windows.Forms.Panel panelCategoryDrinkOrder;
        private System.Windows.Forms.Button btnOrderFood;
        private System.Windows.Forms.Button btnOrderDrinks;
        private System.Windows.Forms.Panel panel2;
        private PanelOrder panelOrder1;
    }
}
