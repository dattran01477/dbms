using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using MilkTea_app.BLL;
using DevExpress.XtraEditors.Filtering.Templates;

namespace MilkTea_app
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        DataStore data;
        public XtraReport1()
        {
            InitializeComponent();
        }
        public XtraReport1(string userName, string pass)
        {
            data = new DataStore(userName, pass);
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            try
            {
                Date aDateTime = new Date();
                this.Parameters["soHoaDon"].Value = data.getHoaDonNgay();
                this.Parameters["doanhThu"].Value = data.getDoanhThuTheoNgay();
                this.Parameters["tongChiecKhau"].Value = data.getTongChiecKhau();
                this.Parameters["dateNow"].Value = DateTime.Now;
                this.Parameters["danhMucBanNhieu"].Value = "Trà Sữa";
                this.RequestParameters = false;
            }
            catch(Exception e)
            {
                
            }
          


        }

    }
}
