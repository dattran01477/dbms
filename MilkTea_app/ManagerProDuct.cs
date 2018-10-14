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
        public int statusManager = 0; //0: tt ban dau, 1 tt them moi, 2 tt sua, 3 tt xoa, 4 tt click vao cell tren datagridview
        DataStore data = new DataStore();
        List<Category> category = new List<Category>();
        public class CategoryId
        {
            public string categoryid;
            public string categoyname;
        }
        public List<CategoryId> arrcategory=new List<CategoryId>();
        public CategoryId categorytemmp;
        public ManagerProDuct()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            loadButton();
            category = data.getCategory();
            foreach(var a  in category)
            {
                categorytemmp = new CategoryId();
                categorytemmp.categoryid = a._id.ToString();
                categorytemmp.categoyname = a.name;
                arrcategory.Add(categorytemmp);
                cmbCategory.Items.Add(a.name);
            }
          

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbCategory.Text == null)
            {
                return;
            }
            else
            {
                loadDatacmb();  //Tách thành hàm load data riêng cho cmb để tái sử dụng nhiều lần.
            }
          
           
        }
        private void loadDatacmb()
        {
            DataTable dataTable = new DataTable();
            List<Products> listProDuct = data.getAllProduct(cmbCategory.SelectedItem.ToString());

            dataTable.Columns.Add("Tên");
            dataTable.Columns.Add("Giá");
            foreach (var a in listProDuct)
            {
                dataTable.Rows.Add(a.name, a.price);
            }
            dgvProduct.DataSource = dataTable;
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            statusManager = 4;
            loadButton();
            if (dgvProduct.CurrentCell != null && dgvProduct.CurrentCell.Value != null)
            {
                txtTensanpham.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                txtGia.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            }
                
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            statusManager = 1;
            resetText();
            loadButton();
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
                        foreach (CategoryId a in arrcategory)
                        {
                            if (a.categoyname == cmbCategory.SelectedItem.ToString())
                            {
                                data.postProducts(txtTensanpham.Text, txtGia.Text, a.categoryid);
                                loadDatacmb();
                                break;
                            }
                            
                        }
                        break;
                    }
                case 2:
                    {
                        foreach (CategoryId a in arrcategory)
                        {
                            if (a.categoyname == cmbCategory.SelectedItem.ToString())
                            {
                                data.updateProducts(txtTensanpham.Text, txtGia.Text, a.categoryid);
                                loadDatacmb();
                                break;
                            }

                        }
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
                case 0 :
                    {
                        btnThem.Enabled = true;
                        btnSua.Enabled = false;
                        btnCapnhat.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTensanpham.Enabled = false;
                        txtGia.Enabled = false;
                        txtMaxacthuc.Enabled = false;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnCapnhat.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTensanpham.Enabled = true;
                        txtGia.Enabled = true;
                        txtMaxacthuc.Enabled = true;
                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnCapnhat.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTensanpham.Enabled = true;
                        txtGia.Enabled = true;
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
                        txtTensanpham.Enabled = true;
                        txtGia.Enabled = true;
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
                        txtTensanpham.Enabled = false;
                        txtGia.Enabled = false;
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
            txtTensanpham.ResetText();
            txtGia.ResetText();
            txtMaxacthuc.ResetText();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            statusManager = 0;
            resetText();
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
            data.deleteProducts(txtTensanpham.Text);
            statusManager = 0;
            loadButton();
            loadDatacmb();
        }
    }
}
