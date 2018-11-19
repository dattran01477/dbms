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
using MongoDB.Bson.Serialization;
using DevExpress.Utils;

using MongoDB.Bson;
using Bunifu.Framework.UI;


namespace MilkTea_app
{
    public partial class PanelOrder : UserControl
    {
        int margin;
        int size;


        private DataStore data;
        private List<Products> productsOrder = new List<Products>();
        BsonArray bsonProductsOrder = new BsonArray();

        private int X,Y=0;

        int width;
        int height;

        private string collectorName;
        private string userName;
        private string pass;

        public int Height1 { get => height; set => height = value; }
        public int Width1 { get => width; set => width = value; }
        public string CollectorName { get => collectorName; set => collectorName = value; }

        public PanelOrder()
        {


            InitializeComponent();
            txtDisCount.Text = "0";
           
            margin = ((flowLayoutPnBtn.Width - 4 * 180) / (4 + 2));
            size = flowLayoutPnBtn.Width / 4;
        }

        public PanelOrder(string userName, string pass)
        {
            this.userName = userName;
            this.pass = pass;

            InitializeComponent();
            txtDisCount.Text = "0";

            margin = ((flowLayoutPnBtn.Width - 4 * 180) / (4 + 2));
            size = flowLayoutPnBtn.Width / 4;

            data = new DataStore(userName, pass);

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
            flowLayoutPnBtn.Controls.Clear();
            collectorName = collName;
            List<Products> products = new List<Products>();
            products = data.getAllProduct(collectorName);
            AddButton(products);

        }

        

        private void AddButton(List<Products> products)
        { 
            Button btn;
            BunifuElipse el = new BunifuElipse();
            Random rnd = new Random();

            Font font = new Font("Century Gothic", 10);
            foreach(var a in products)
            {
                //if (X+180 >= flowLayoutPnBtn.Width)
                //{
                   
                //       Y = Y + 80;
                //        X = 0;
                   
                //}
               
                btn = new Button();
                el.TargetControl = btn;
                btn.Size = new Size(size, 70);
                btn.Text = a.name;          
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(152), rnd.Next(256));
                X = X + margin;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = font;
                btn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right| AnchorStyles.Left);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.BackColor = randomColor;
                btn.ForeColor = Color.White;
                el.ElipseRadius = 20;
                btn.Click += Btn_Click;
           
                flowLayoutPnBtn.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            txtSum.Text = "";

            gridControlOder.DataSource = null;
            gridViewOrder.Columns.Clear();
            this.gridViewOrder.AddNewRow();
            Button btn = sender as Button;
            productsOrder.Add(data.getInfoProduct(btn.Text));

            DataTable temp = new DataTable();
            temp.Columns.Add("name");
            temp.Columns.Add("price");
            temp.Columns.Add("amount");

            foreach (var a in productsOrder)
            temp.Rows.Add(a.name, a.price, 1);
            gridControlOder.DataSource = temp;

            txtSum.Text = SumPrice(productsOrder,int.Parse(txtDisCount.Text)).ToString();
           
           


        }
        private double SumPrice(List<Products> products,int chiecKhau)
        {
            double sum = 0;
         
                
            foreach (var a in productsOrder)
            {
                sum += a.price;
            }
            if (chiecKhau == 0)
            {
                return sum;
            }
            else
            {
                sum = sum - sum * ((double)chiecKhau / 100);
            }

            return sum;        
        }
   
        private void button2_Click(object sender, EventArgs e)
        {

        }

   

        private void pnBtnProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrderDrinks_Click(object sender, EventArgs e)
        {
            foreach(var a in productsOrder)
            bsonProductsOrder.Add(a.ToBsonDocument());
            try
            {
                data.addOrder(bsonProductsOrder, int.Parse(txtSum.Text), int.Parse(txtDisCount.Text), "23");
                bsonProductsOrder.Clear();
                productsOrder.Clear();
                DataTable temp = new DataTable();
                gridControlOder.DataSource = temp;
                
                

            }
            catch
            {

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtDisCount_TextChanged(object sender, EventArgs e)
        {
          try
            {
                txtSum.Text = SumPrice(productsOrder, int.Parse(txtDisCount.Text)).ToString();
            }
            catch
            {
                txtSum.Text = SumPrice(productsOrder,0).ToString();
            }
          
        }

        private void gridControlOder_Click(object sender, EventArgs e)
        {

        }

        private void pnBtnProducts_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public int AtOder;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            AtOder = productsOrder.Count - 1;
            string column1Name = gridViewOrder.Columns[1].Name;
            if (gridViewOrder.RowCount>0)
            {
              
                gridViewOrder.DeleteRow(gridViewOrder.FocusedRowHandle);
                productsOrder.RemoveAt(0);
               
            }
            txtSum.Text = SumPrice(productsOrder, int.Parse(txtDisCount.Text)).ToString();
        }

        private void GridViewOrder_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }

        private void gridControlOder_Click_1(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
