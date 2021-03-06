﻿using System;
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
    public partial class Users : UserControl
    {
        public int statusManager = 0;
        DataStore data;
        List<Userclass> listUsers;
        private string userName;
        private string pass;
        public Users()
        {
            
            InitializeComponent();
            LoadData();
        }
        public Users(string username,string password)
        {
            this.userName = username;
            this.pass = password;
            InitializeComponent();
            LoadData();
        }
        
        public void LoadData()
        {
            listUsers = new List<Userclass>();
            
            listUsers.Clear();
            data = new DataStore(userName,pass);
            listUsers = data.getUsers();
            DataTable dt = new DataTable(userName,pass);
            dt.Columns.Add("User");
            dt.Columns.Add("Quyen");
            dt.Columns.Add("Password");
            bool itemcmp = true;
            foreach (var a in listUsers)
            {
                itemcmp = true;
                dt.Rows.Add(a.usersname,a.role,a.pass);
                foreach (var items in cmbQuyen.Items)
                {
                    if (a.role == items.ToString()) itemcmp = false;
                    
                }
                if (itemcmp) { cmbQuyen.Items.Add(a.role); }
               
            }
            dgvUser.Font = new Font("Century Gothic",11);
            dgvUser.DataSource = dt;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            data.deleteUser(txtUsername.Text);
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
                        data.addUser(txtUsername.Text,txtPassword.Text,cmbQuyen.Text);
                        LoadData();
                        break;
                    }
                case 2:
                    {
                        data.updateUser(txtUsername.Text, txtPassword.Text, cmbQuyen.Text);
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
                        txtUsername.Enabled = false;
                        txtPassword.Enabled = false;
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
                        txtUsername.Enabled = true;
                        txtPassword.Enabled = true;
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
                        btnXoa.Enabled = false;
                        txtUsername.Enabled = true;
                        txtPassword.Enabled = true;
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
                        btnXoa.Enabled = false;
                        txtUsername.Enabled = true;
                        txtPassword.Enabled = true;
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
                        txtUsername.Enabled = false;
                        txtPassword.Enabled = false;
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
            txtUsername.ResetText();
            txtPassword.ResetText();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
                statusManager = 0;
                resetText();
                loadButton();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            statusManager = 4;
            txtUsername.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
           cmbQuyen.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            loadButton();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
