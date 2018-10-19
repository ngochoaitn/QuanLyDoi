using QuanLyDoi.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDoi.Forms
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await Global.LoadBangMaAsync(Global.DbBangMa);
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

        private void btnQuanLyThongTinCanBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.CanBo.DanhSachCanBo().ShowDialog();
        }

        private void btnBaoCaoDinhKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Forms.CongVan.BaoCaoDinhKy().ShowDialog();
        }
    }
}
