using MilkTea_app.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
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
            loadip();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            CallWithAsync();


        }

        private void ckIsManager_CheckedChanged(object sender, EventArgs e)
        {

        }

        async void CallWithAsync()
        {
            try
            {
                MessageBox.Show("Xin vui lòng đợi");
                bool t1 = await IsConn();

                if (data.isConnect)
                {
                    List<String> role = data.getRoles(txtName.Text);

                    AppMilkTea appMilkTea = new AppMilkTea(txtName.Text, txtPass.Text, role);
                    appMilkTea.Show();
                    DataStore.roles = role;
                    this.Hide();
                    appMilkTea.FormClosing += AppMilkTea_FormClosing;
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

        private void AppMilkTea_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        public Task<bool> IsConn()
        {
            DataStore.hostName = cmbIP.Text ;
            data = new DataStore(txtName.Text, txtPass.Text);

            return Task.Run<bool>(() => { return data.isConnect; });
        }
        string ipAddress;
        private void loadip()
        {
            string ipBase = "";

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipBase = ip.ToString();
                    ipAddress = ipBase;
                }
            }

            String[] ipPart = ipBase.Split('.');
            ipBase = ipPart[0] + "." + ipPart[1] + "." + ipPart[2] + ".";

            for (int i = 0; i < 255; i++)
            {
                string ip = ipBase + i.ToString();

                Ping p = new Ping();
                p.PingCompleted += new PingCompletedEventHandler(p_PingCompleted);
                p.SendAsync(ip, 100, ip);
            }
            cmbIP.Text = ipAddress;
        }

        private void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            PingReply pr = e.Reply;
            if (e.Reply.Address.ToString() != "0.0.0.0" && e.Reply.Address.ToString() != ipAddress)
            {
                //cmbIP.Items.Add(e.Reply.Address.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
