using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTea_app.DAL;
using MilkTea_app.DTO;
using MilkTea_app.BLL;

namespace MilkTea_app
{
    public partial class TaiKhoang : Form
    {
        DataStore data = new DataStore();
        private string user;
        private string pass;
        public TaiKhoang()
        {
            InitializeComponent();
            txtMKcu.Text = pass;
        }
        public TaiKhoang(string _user,string _pass) : this()
        {
            this.user = _user;
            this.pass = _pass;
        }

        public string User
        {
            get { return user; }
            set { pass = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private void txtMKcu_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtMKmoi.Text != txtMKmoi2.Text) MessageBox.Show("Chưa khớp mật khẩu!");
            else
                if(txtMKcu.Text==pass) { data.Changpassword(user,txtMKmoi.Text); }
            else { MessageBox.Show("Mật khẩu cũ chưa đúng!"); };
        }
    }
}
