using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea_app
{
    public partial class QuanLy : UserControl
    {
        bool isDanhMuc = false;
        bool isProduct = false;
        Manager managerCategory=null;
        ManagerProDuct managerProDuct=null;
        private string userName;
        private string pass;

        public QuanLy()
        {

            InitializeComponent();
     
            managerCategory.Dock = DockStyle.Fill;
            //  pnDGV.Controls.Clear();
            managerCategory.AutoScaleMode = AutoScaleMode.None;
            managerProDuct.AutoScaleMode = AutoScaleMode.None;
            pnQL.Controls.Add(managerProDuct);
        }

        public QuanLy(string userName, string pass)
        {
            this.userName = userName;
            this.pass = pass;

            InitializeComponent();
            managerCategory = new Manager(userName, pass);
            managerProDuct = new ManagerProDuct(userName,pass);
            managerCategory.Dock = DockStyle.Fill;
            //  pnDGV.Controls.Clear();
            managerCategory.AutoScaleMode = AutoScaleMode.None;
            managerProDuct.AutoScaleMode = AutoScaleMode.None;
            pnQL.Controls.Add(managerProDuct);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            isProduct = true;
            ShowPn();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            isDanhMuc = true;
            ShowPn();
        }
        private void ShowPn()
        {
            if(isDanhMuc)
            {
                managerCategory.Dock = DockStyle.Fill;
                //  pnDGV.Controls.Clear();
                animator1.Hide(managerProDuct);
                pnQL.Controls.Add(managerCategory);
                managerCategory.Hide();
                animator2.ShowSync(managerCategory);
                isDanhMuc = false;
                isProduct = false;
               
            }
            if(isProduct)
            {
                managerProDuct.Dock = DockStyle.Fill;
                //  pnDGV.Controls.Clear();
                animator1.Hide(managerCategory);
                pnQL.Controls.Add(managerProDuct);
                managerProDuct.Hide();
                animator2.ShowSync(managerProDuct);
                isDanhMuc = false;
                isProduct = false;
            }
        }
    }
}
