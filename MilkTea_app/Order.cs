using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTea_app.DTO;
using MilkTea_app.BLL;

namespace MilkTea_app
{
    public partial class Order : UserControl
    {

        bool isOrderFood = false;
        bool isOrderDrink = false;
        bool isOrderTopping = false;

        DataStore data = new DataStore();
        public Order()
        {
            InitializeComponent();
            panelOrder1.SetWidthHeight(panelOrder1.Width, panelOrder1.Height);
            AddCategory(data.getCategoryDrink(), panelCategoryDrinkOrder);
            AddCategory(data.getCategoryFood(), panelCategoryFoodOrder);
     
        }
        public void SetView(int width)
        {
            sidePanel1.Width = width;
        }
        private void AddCategory(List<Category> category, Panel pn)
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
            Button btn = sender as Button;
            panelOrder1.LoadData(btn.Text);

        }
        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            Button btnTemp = sender as Button;
            AddScroll(btnTemp);
            if (isOrderFood == false)
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

        private void btnOrderDrinks_Click(object sender, EventArgs e)
        {
            Button btnTemp = sender as Button;
            AddScroll(btnTemp);
            if (isOrderDrink == false)
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
        private void MoveButtonOverFlow(bool isOrderType, Button btnOrderMove, Panel pnThisButtonOrder, Panel pnOrderMove)
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
        private void AddScroll(Button btn)
        {
            label.Location = new Point(label.Location.X, btn.Location.Y);

        }
    }
}
