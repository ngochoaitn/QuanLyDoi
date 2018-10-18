using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDoi
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void giayDiDuongBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            alertControl1.Show(this, "Caption", "Text");
            new Forms.GiayDiDuong.frmNhapThongTinKhoiTao().ShowDialog();
        }

        private void timKiemTepBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.TimKiem.frmTimKiemFileWord().ShowDialog();
        }

        private void quanLyCongVanDenBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.CongVan.frmCongVanDen().ShowDialog();
        }
    }
}
