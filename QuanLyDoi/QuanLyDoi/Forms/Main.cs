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

        public void ShowForm(Form frmCon)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.Text == frmCon.Text)
                {
                    child.WindowState = FormWindowState.Normal;
                    child.Focus();
                    return;
                }
            }
            try
            {
                frmCon.MdiParent = this;
                frmCon.Show();
            }
            catch { }
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await Global.LoadBangMaAsync(Global.DbBangMa);
        }

        private void giayDiDuongBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            alertControl1.Show(this, "Tiêu đề", "Nội dung");
            new GiayDiDuong.frmNhapThongTinKhoiTao().ShowDialog();
        }

        private void timKiemTepBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new TimKiem.frmTimKiemFileWord());
        }

        private void quanLyCongVanDenBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new CongVan.frmCongVanDen());
        }

        private void btnQuanLyThongTinCanBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new CanBo.DanhSachCanBo());
        }

        private void btnBaoCaoDinhKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new CongVan.BaoCaoDinhKy());
        }

        private void btnDanhSachXuatCanhTraiPhep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new XuatCanhTraiPhep.FormDanhSachXuatCanhTraiPhep());
        }

        private void btnThongKeXuatCanhTraiPhep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new XuatCanhTraiPhep.FormThongKeXuatCanhTraiPhep());
        }
    }
}
