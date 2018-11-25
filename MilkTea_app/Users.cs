using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTea_app.BLL;
using MilkTea_app.DTO;

namespace MilkTea_app
{
    public partial class Users : UserControl
    {
        public int statusManager = 0;
        DataStore data;
        List<Userclass> listUsers;

        public Users()
        {
            
            InitializeComponent();
            LoadUser();
        }
        private string userName;
        private string pass;
        public void LoadUser()
        {
            listUsers = new List<Userclass>();
            
            listUsers.Clear();
            data = new DataStore();
            listUsers = data.getUsers();
            DataTable dt = new DataTable();
            dt.Columns.Add("User");
            dt.Columns.Add("Quyen");
            foreach (var a in listUsers)
            {
                dt.Rows.Add(a.usersname,a.role);
            }
            //foreach (var a in listUsers)
            //{
            //    MessageBox.Show(a.usersname);
            //}
            dgvUser.Font = new Font("Century Gothic",11);
            dgvUser.DataSource = dt;
        }
    }
}
