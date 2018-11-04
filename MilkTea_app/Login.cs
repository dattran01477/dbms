using MilkTea_app.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea_app
{
    public partial class Login : Form
    {
        public static String quyen;
        DataStore data;
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            CallWithAsync();
           
           
        }

        private void ckIsManager_CheckedChanged(object sender, EventArgs e)
        {

        }
        async  void CallWithAsync()
        {
            try
            {
                MessageBox.Show("Xin vui lòng đợi");
                bool t1 = await IsConn();
                if (data.isConnect)
                {
                    
                    AppMilkTea appMilkTea = new AppMilkTea(txtName.Text, txtPass.Text);
                    appMilkTea.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Xin Nhập lại mật khẩu và tên đăng nhập");
                }
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public Task<bool> IsConn( )
        {
            data = new DataStore(txtName.Text, txtPass.Text);
           
            return Task.Run<bool>(() => { return data.isConnect; });
        }
    }
}
