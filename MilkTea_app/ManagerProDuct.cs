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
    public partial class ManagerProDuct : UserControl
    {
        DataStore data = new DataStore();
        List<Category> category = new List<Category>();
        public ManagerProDuct()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            category = data.getCategory();
            foreach(var a  in category)
            {
                cmbCategory.Items.Add(a.name);
            }
          

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (cmbCategory.Text == null)
            {
                return;
            }
            else
            {
                List<Products> listProDuct = data.getAllProduct(cmbCategory.SelectedItem.ToString());
              
                dataTable.Columns.Add("Tên");
                dataTable.Columns.Add("Giá");
                foreach (var a in listProDuct)
                {
                    dataTable.Rows.Add(a.name, a.price);
                }
            }
          
            dgvProduct.DataSource = dataTable;
        }
    }
}
