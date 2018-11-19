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
    public partial class ManagerEmployees : UserControl
    {
        public int statusManager = 0; //0: tt ban dau, 1 tt them moi, 2 tt sua, 3 tt xoa, 4 tt click vao cell tren datagridview
        DataStore data;
        List<Employees> employees = new List<Employees>();
        public ManagerEmployees()
        {
            InitializeComponent();
            LoadData();
        }
        private string userName;
        private string pass;

        public ManagerEmployees(string userName, string pass)
        {
            this.userName = userName;
            this.pass = pass;
            InitializeComponent();
            data = new DataStore(userName, pass);
            if (data.isConnect)
                LoadData();
            else
                return;
        }

        private void LoadData()
        {
            DataTable datatb = new DataTable();
            List<Employees> employeesList = data.GetEmployees();
            datatb.Columns.Add("Mã nhân viên");
            datatb.Columns.Add("Họ tên");
            datatb.Columns.Add("Ngày sinh");
            datatb.Columns.Add("Địa chỉ");
            datatb.Columns.Add("Chức vụ");
            foreach(var a in employeesList)
            {
                datatb.Rows.Add(a.MaNV,a.Hoten,a.Ngaysinh,a.Diachi,a.Chucvu);
            }
            dgvEmployees.DataSource = datatb;
            cmbChucvu.Items.Clear();
            cmbChucvu.Items.Add("Quản Lý");
            cmbChucvu.Items.Add("Nhân viên");
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            statusManager = 1;
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
            data.deleteEmployees(txtMaNV.Text);
            statusManager = 0;
            loadButton();
            resetText();
            LoadData();
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
                        data.addEmployees(txtMaNV.Text,txtTenNV.Text, txtNgaysinh.Text,txtDiachi.Text,cmbChucvu.SelectedItem.ToString());
                        LoadData();
                        break;
                    }
                case 2:
                    {
                        data.updateEmployees(txtMaNV.Text, txtTenNV.Text, txtNgaysinh.Text, txtDiachi.Text, cmbChucvu.SelectedItem.ToString());
                        LoadData();
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
            resetText();
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
                        txtDiachi.Enabled = false;
                        txtMaNV.Enabled = false;
                        txtNgaysinh.Enabled = false;
                        txtTenNV.Enabled = false;
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
                        txtTenNV.Enabled = true;
                        txtNgaysinh.Enabled = true;
                        txtMaNV.Enabled = true;
                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;
                        txtDiachi.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnCapnhat.Enabled = false;
                        btnXoa.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTenNV.Enabled = true;
                        txtNgaysinh.Enabled = true;
                        txtMaNV.Enabled = true;
                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;
                        txtDiachi.Enabled = true;
                        break;
                    }
                case 3:
                    {
                        btnThem.Enabled = false;
                        btnSua.Enabled = false;
                        btnCapnhat.Enabled = false;
                        btnXoa.Enabled = false;
                        btnXoa.Enabled = false;
                        txtTenNV.Enabled = true;
                        txtNgaysinh.Enabled = true;
                        txtMaNV.Enabled = true;
                        txtDiachi.Enabled = true;
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
                        btnXoa.Enabled = false;
                        txtTenNV.Enabled = false;
                        txtNgaysinh.Enabled = false;
                        txtMaNV.Enabled = false;
                        btnLuu.Enabled = false;
                        btnHuy.Enabled =false;
                        txtDiachi.Enabled = false;
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
            txtDiachi.ResetText();
            txtMaNV.ResetText();
            txtNgaysinh.ResetText();
            txtTenNV.ResetText();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            statusManager = 0;
            resetText();
            loadButton();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgvEmployees.CurrentRow.Cells[0].ToString());
            txtMaNV.Text = dgvEmployees.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
            txtNgaysinh.Text= dgvEmployees.CurrentRow.Cells[2].Value.ToString();
            txtDiachi.Text= dgvEmployees.CurrentRow.Cells[3].Value.ToString();
            cmbChucvu.Text= dgvEmployees.CurrentRow.Cells[4].Value.ToString();
            loadButton();
            btnSua.Enabled = true;
        }
    }
}
