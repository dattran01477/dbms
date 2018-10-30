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
//using DevExpress.XtraLayout.Customization;

namespace MilkTea_app
{
    public partial class Manager : UserControl
    {
        DataStore data = new DataStore();
        List<Category> category = new List<Category>();
        public int statusManager=0;
        public Manager()
        {
            InitializeComponent();
            LoadData();
        }
        public void SetWidthHeight(int width, int height)
        {
          
        }
        private void LoadData()
        {
            loadButton();
            cmbCategory.Items.Add("Drink");
            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Topping");

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCategory.Text == null)
            {
                return;
            }
            else
            {
                loadDatacmb();
            }
        }
        private void loadDatacmb()
        {
            loadButton();
            DataTable dataTable = new DataTable();
            List<Category> listCategory = data.getCategory();

            dataTable.Columns.Add("Ten");
            dataTable.Columns.Add("Loai");
            foreach (var a in listCategory)
            {
                if(a.type.ToString()==cmbCategory.SelectedItem.ToString())
                dataTable.Rows.Add(a.name, a.type);
            }
            dgvProduct.DataSource = dataTable;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (statusManager)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        data.postCategory(txtTendanhmuc.Text, cmbCategory.SelectedItem.ToString());
                        loadDatacmb(); 
                        break;
                    }
                case 2:
                    {
                        data.updateCategory(txtTendanhmuc.Text, cmbCategory.SelectedItem.ToString());
                        loadDatacmb();
                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {

                        break;
                    }
                default:
                    {
                        MessageBox.Show("Lỗi thao tác!");
                        break;
                    }
            }
            statusManager = 0;
            loadButton();
        }
        public void loadButton()
        {
            switch (statusManager)
            {
                case 0:
                    {
                        btnThem.Enabled = true;
                        btnSua.Enabled = false;
                        btnCapnhat.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTendanhmuc.Enabled = false;
                        txtMaxacthuc.Enabled = false;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        resetText();
                        break;
                    }
                case 1:
                    {
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnCapnhat.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTendanhmuc.Enabled = true;
                        txtMaxacthuc.Enabled = true;
                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;
                        resetText();
                        break;
                    }
                case 2:
                    {
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnCapnhat.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTendanhmuc.Enabled = true;
                        txtMaxacthuc.Enabled = true;
                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;
                        break;
                    }
                case 3:
                    {
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnCapnhat.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTendanhmuc.Enabled = true;
                        txtMaxacthuc.Enabled = true;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        break;
                    }
                case 4:
                    {
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnCapnhat.Enabled = true;
                        btnXoa.Enabled = true;
                        txtTendanhmuc.Enabled = true;
                        txtMaxacthuc.Enabled = false;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                      
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Lỗi thao tác!");
                        break;
                    }
            }
            }
        public void resetText()
        {
            txtTendanhmuc.ResetText();
            txtMaxacthuc.ResetText();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            statusManager = 4;
            if(dgvProduct.CurrentCell!=null && dgvProduct.CurrentCell.Value!=null)
            {
                txtTendanhmuc.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            }
            loadButton();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            statusManager = 1;
            loadButton();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            statusManager = 2;
            loadButton();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            data.deleteCategory(txtTendanhmuc.Text);
            statusManager = 0;
            loadButton();
            loadDatacmb();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            statusManager = 0;
            loadButton();
        }
    }
}
