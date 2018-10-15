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

namespace MilkTea_app
{
    public partial class AppMilkTea : Form
    {
        bool isOrderFood = false;
        bool isOrderDrink = false;
        bool isOrderTopping = false;

        DataStore data = new DataStore();
        List<object> component = new List<object>();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        /*chưa cần*/
        private void AddOject()
        {
            component.Add(btnOrderDrinks);
            component.Add(panelCategoryDrinkOrder);
            component.Add(btnOrderFood);
            component.Add(panelCategoryFoodOrder);
        }
        private void AddScroll(Button btn)
        {
            label.Location = new Point(label.Location.X, btn.Location.Y);
            
        }
        public AppMilkTea()
        {
            InitializeComponent();
       
            pnLogo.BorderStyle = BorderStyle.None;
            panelOrder1.SetWidthHeight(panelOrder1.Width, panelOrder1.Height);
            AddCategory(data.getCategoryDrink(),panelCategoryDrinkOrder);
            AddCategory(data.getCategoryFood(),panelCategoryFoodOrder);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void MoveButtonOverFlow(bool isOrderType,Button btnOrderMove,Panel pnThisButtonOrder,Panel pnOrderMove)
        {
            if (isOrderType)
            {
                btnOrderMove.Location = new Point(btnOrderMove.Location.X, btnOrderMove.Location.Y + pnThisButtonOrder.Height);
            }
            else
            {
                btnOrderMove.Location = new Point(btnOrderMove.Location.X, btnOrderMove.Location.Y - pnThisButtonOrder.Height);
   
            }

            pnOrderMove.Location = new Point(btnOrderMove.Location.X + 25, btnOrderMove.Location.Y + 70);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btnTemp = sender as Button;
            AddScroll(btnTemp);
            if (isOrderDrink==false)
            {
                isOrderDrink = true;
                panelCategoryDrinkOrder.AutoSize = true;
               
                MoveButtonOverFlow(isOrderDrink, btnOrderFood, panelCategoryDrinkOrder, panelCategoryFoodOrder);
                MoveButtonOverFlow(isOrderDrink, btnTopping, panelCategoryDrinkOrder, pnOrderTopping);



            }
            else
            {
                isOrderDrink = false;
                MoveButtonOverFlow(isOrderDrink, btnOrderFood, panelCategoryDrinkOrder, panelCategoryFoodOrder);
                MoveButtonOverFlow(isOrderDrink, btnTopping, panelCategoryDrinkOrder, pnOrderTopping);
                panelCategoryDrinkOrder.AutoSize = false;

               
              
            }
                

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btnTemp = sender as Button;
            AddScroll(btnTemp);
            if (isOrderFood==false)
            {
                isOrderFood = true;
                panelCategoryFoodOrder.AutoSize = true;
          
                MoveButtonOverFlow(isOrderFood, btnTopping, panelCategoryFoodOrder, pnOrderTopping);
            }
            else
            {
                isOrderFood = false;
                MoveButtonOverFlow(isOrderFood, btnTopping, panelCategoryFoodOrder, pnOrderTopping);
                panelCategoryFoodOrder.AutoSize = false;

           
            }
        }
        private void btnTopping_Click(object sender, EventArgs e)
        {
            Button btnTemp = sender as Button;
            AddScroll(btnTemp);
            if (isOrderTopping == false)
            {
                isOrderTopping = true;
                pnOrderTopping.AutoSize = true;
                panelOrder1.LoadData(btnTopping.Text);

               
            }
            else
            {
                isOrderTopping = false;
                pnOrderTopping.AutoSize = false;


            }

        }
        /*add category*/

        private void AddCategory  (List<Category> category,Panel pn)
        {
            int xBtn = 0, yBtn = 0;
            Button btn;

            foreach(var temp  in category)
            {
         
                btn = new Button();
                 btn.Size = new Size(180, 40);
                btn.Location = new Point(xBtn, yBtn);
                btn.FlatAppearance.BorderSize = 0;
                btn.Text = temp.name;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += Btn_Click;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                yBtn = yBtn + 50;
                pn.Controls.Add(btn);

            }

        }
        private void AddCategory(List<Topping> category,Panel pn)
        {
            int xBtn = 0, yBtn = 0;
            Button btn;

            foreach (var temp in category)
            {

                btn = new Button();
                btn.Size = new Size(180, 40);
                btn.Location = new Point(xBtn, yBtn);
                btn.FlatAppearance.BorderSize = 0;
                btn.Text = temp.name;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += Btn_Click;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                yBtn = yBtn + 50;
                pn.Controls.Add(btn);

            }

        }



        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn= sender as Button;
            panelOrder1.LoadData(btn.Text);

        }

        private void AppMilkTea_Load(object sender, EventArgs e)
        {

        }

        private void panelOrder1_Load(object sender, EventArgs e)
        {

        }

        private void panelOrder1_Resize(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
