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
        bool isManagerEmployees = false;
        bool isUsers = false;
        Manager managerCategory=null;
        ManagerProDuct managerProDuct=null;
        ManagerEmployees managerEmployees = null;
        Users usersmanager = null;
        private string userName;
        private string pass;

        public QuanLy()
        {

            InitializeComponent();
     
            managerCategory.Dock = DockStyle.Fill;
            managerCategory.AutoScaleMode = AutoScaleMode.None;
            managerProDuct.AutoScaleMode = AutoScaleMode.None;
            managerEmployees.AutoScaleMode = AutoScaleMode.None;
            usersmanager.AutoScaleMode = AutoScaleMode.None;
            pnQL.Controls.Add(managerEmployees);
            isManagerEmployees = true;
            managerCategory.Dock = DockStyle.Fill;
        }

        public QuanLy(string userName, string pass)
        {
            this.userName = userName;
            this.pass = pass;

            InitializeComponent();
            managerCategory = new Manager(userName, pass);
            managerProDuct = new ManagerProDuct(userName,pass);
            managerEmployees = new ManagerEmployees(userName,pass);
            usersmanager = new Users(userName,pass);
            //  pnDGV.Controls.Clear();
            managerCategory.AutoScaleMode = AutoScaleMode.None;
            managerProDuct.AutoScaleMode = AutoScaleMode.None;
            managerEmployees.AutoScaleMode = AutoScaleMode.None;
            usersmanager.AutoScaleMode = AutoScaleMode.None;
            managerCategory.Dock = DockStyle.Fill;
            pnQL.Controls.Add(managerCategory);
            isDanhMuc = true;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            managerProDuct.Dock = DockStyle.Fill;
            if (isManagerEmployees)  animator1.Hide(managerEmployees);
            if (isDanhMuc) animator1.Hide(managerCategory);
            if (isUsers) animator1.Hide(usersmanager);
            isProduct = true;
            isDanhMuc = false;
            isManagerEmployees = false;
            isUsers = false;
            ShowPn();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if(isManagerEmployees) animator1.Hide(managerEmployees);
            if(isProduct) animator1.Hide(managerProDuct);
            if (isUsers) animator1.Hide(usersmanager);
            isDanhMuc = true;
            isProduct = false;
            isManagerEmployees = false;
            isUsers = false;
            ShowPn();
        }
        private void btnManagerEmployees_Click(object sender, EventArgs e)
        {
            managerEmployees.Dock = DockStyle.Fill;
            if (isProduct) animator1.Hide(managerProDuct);
            if (isDanhMuc) animator1.Hide(managerCategory);
            if (isUsers) animator1.Hide(usersmanager);
            isManagerEmployees = true;
            isUsers = false;
            isDanhMuc = false;
            isProduct = false;
            ShowPn();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            usersmanager.Dock = DockStyle.Fill;
            if (isProduct) animator1.Hide(managerProDuct);
            if (isDanhMuc) animator1.Hide(managerCategory);
            if (isManagerEmployees) animator1.Hide(managerEmployees);
            isUsers = true;
            isManagerEmployees = false;
            isDanhMuc = false;
            isProduct = false;
            ShowPn();
        }
        private void ShowPn()
        {
            if(isDanhMuc)
            {
                pnQL.Controls.Add(managerCategory);
                managerCategory.Hide();
                animator2.ShowSync(managerCategory);
            }
            if(isProduct)
            {
                pnQL.Controls.Add(managerProDuct);
                managerProDuct.Hide();
                animator2.ShowSync(managerProDuct);
            }
            if(isManagerEmployees)
            {
                pnQL.Controls.Add(managerEmployees);
                managerEmployees.Hide();
                animator2.ShowSync(managerEmployees);
            }
            if(isUsers)
            {
                pnQL.Controls.Add(usersmanager);
                usersmanager.Hide();
                animator2.ShowSync(usersmanager);
            }
        }

        
    }
}
