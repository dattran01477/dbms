using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MilkTea_app.BLL;
using MilkTea_app.DTO;
using Bunifu.Framework.UI;
using System.Windows.Media;

namespace MilkTea_app
{
    public partial class AppMilkTea : Form
    {
        bool isOerder = false;
        bool isQuanLy = false;
        bool isThongKe = false;

        Order or = new Order();
        QuanLy ql = new QuanLy();
        Stack<BunifuThinButton2> sbtn = new Stack<BunifuThinButton2>();
        Stack<Object> pn = new Stack<object>();

        Object pnHienTai;

        public AppMilkTea()
        {
            InitializeComponent();
            or.Dock = DockStyle.Fill;
            //  pnDGV.Controls.Clear();
            ql.AutoScaleMode = AutoScaleMode.None;
            or.AutoScaleMode = AutoScaleMode.None;
            pnDGV.Controls.Add(or);
         
        

          


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            BunifuThinButton2 btn = sender as BunifuThinButton2;
            isOerder = true;
            Show(btn);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            BunifuThinButton2 btn = sender as BunifuThinButton2;
            isQuanLy = true;
            Show(btn);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            BunifuThinButton2 btn = sender as BunifuThinButton2;
            isThongKe = true;
            Show(btn);
        }
        private void ChangeBtn(BunifuThinButton2 btn)
        {
            if(sbtn.Count==0)
            {
                System.Drawing.Color _color = System.Drawing.ColorTranslator.FromHtml("#FFD039");
                btn.IdleFillColor = _color;
                sbtn.Push(btn);
            }
            else
            {
                //tra lại mau
               while(sbtn.Count!=0)
                {
                    BunifuThinButton2 btntemp = sbtn.Pop();
                    System.Drawing.Color _color = System.Drawing.ColorTranslator.FromHtml("#323741");
                    btntemp.IdleFillColor = _color;
                  
                }
                System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#FFD039");
                btn.IdleFillColor = color;
                sbtn.Push(btn);
            }
           
        }
        private void Show(BunifuThinButton2 btn)
        {
            
            ChangeBtn(btn);
            if(isQuanLy==true)
            {
                ql.Dock = DockStyle.Fill;
              //  pnDGV.Controls.Clear();
                animator1.Hide(or);
                pnDGV.Controls.Add(ql);
                ql.Hide();
                animator2.ShowSync(ql);
                isOerder = false;
                isThongKe = false;
                isQuanLy = false;
            }
            if(isOerder==true)
            {
               
                or.Dock = DockStyle.Fill;
                //   pnDGV.Controls.Clear();
                animator1.Hide(ql);
                pnDGV.Controls.Add(or);
                ql.Hide();
                animator2.ShowSync(or);
                isOerder = false;
                isThongKe = false;
                isQuanLy = false;
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
