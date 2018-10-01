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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;

namespace MilkTea_app
{
    public partial class PanelOrder : UserControl
    {
        private DataStore  data= new DataStore();
        private List<Products> productsOrder = new List<Products>();

        private int X,Y=0;

        int width;
        int height;

        private string collectorName;

        public int Height1 { get => height; set => height = value; }
        public int Width1 { get => width; set => width = value; }
        public string CollectorName { get => collectorName; set => collectorName = value; }

        public PanelOrder()
        {
            InitializeComponent();
           
        }
       public void SetWidthHeight(int width,int height)
        {
             this.width=width/4*3;
             this.height=height;
            LoadData(collectorName);
        }
        public void LoadData(string collName)
        {
            X = 0;
            Y = 0;
            pnBtnProducts.Controls.Clear();
            collectorName = collName;
            List<Products> products = new List<Products>();
            products = data.getAllProduct(collectorName);
            AddButton(products);
        }

        

        private void AddButton(List<Products> products)
        { 
            SimpleButton btn;
            Random rnd = new Random();
            foreach(var a in products)
            {
                if (X + 180 >= Width1)
                {
                    Y = Y + 80;
                    X = 0;
                }
                btn = new SimpleButton();
                btn.ButtonStyle = BorderStyles.Default ;
                btn.Size = new Size(180, 70);
                btn.Text = a.name;
                btn.Appearance.Font = new Font("arial", 10);
                btn.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                btn.Location = new Point(X+40, Y+20);
                btn.BackColor = randomColor;
                btn.Click += Btn_Click;
                X = X + 190;
                pnBtnProducts.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            txtSum.Text = "";

            gridControlOder.DataSource = null;
            gridViewOrder.Columns.Clear();


            this.gridViewOrder.AddNewRow();
            SimpleButton btn = sender as SimpleButton;
            productsOrder.Add( data.getInfoProduct(btn.Text));

            DataTable temp = new DataTable();
            temp.Columns.Add("name");
            temp.Columns.Add("price");
            temp.Columns.Add("amount");

            foreach (var a in productsOrder)
            temp.Rows.Add(a.name, a.price, 1);
            gridControlOder.DataSource = temp;

            txtSum.Text = SumPrice(productsOrder).ToString();
           
        }
        private double SumPrice(List<Products> products,int chiecKhau)
        {
            double sum = 0;
            foreach (var a in productsOrder)
            {
                sum += a.price;
            }
            return sum * chiecKhau / 100;
        }
        private double SumPrice(List<Products> products)
        {
            double sum = 0;
            foreach (var a in productsOrder)
            {
                sum += a.price;
            }
            return sum;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

   

        private void pnBtnProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
