namespace MilkTea_app
{
    partial class Form2
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
            this.users1 = new MilkTea_app.Users();
            this.SuspendLayout();
            // 
            // users1
            // 
            this.users1.Location = new System.Drawing.Point(13, 12);
            this.users1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.users1.Name = "users1";
            this.users1.Size = new System.Drawing.Size(1242, 488);
            this.users1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1375, 674);
            this.Controls.Add(this.users1);
            this.Font = new System.Drawing.Font("MS Reference Specialty", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trà Sữa Di&Pi";
            this.Load += new System.EventHandler(this.AppMilkTea_Load);
            this.ResumeLayout(false);

        }

        #endregion
    
    private System.Windows.Forms.Panel panel1;
        private Users users1;
    }
}