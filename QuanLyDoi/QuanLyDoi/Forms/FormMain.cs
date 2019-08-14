using QuanLyDoi.Forms.HeThong;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyDoi.Forms
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool _close = false;
        public FormMain()
        {
            InitializeComponent();
        }

        public void ShowForm(Form frmCon, bool multi=false)
        {
            if (!multi)
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
            }
            try
            {
                frmCon.MdiParent = this;
                frmCon.Show();
                frmCon.FormClosing += (s1, e1) =>
                {
                    if (frmCon is FormIntro && !_close)
                        e1.Cancel = true;
                };
            }
            catch { }
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await Global.LoadBangMaAsync(Global.DbBangMa);
            this.ShowForm(new FormIntro());
            alertControl1.Show(this, "Các công tác trọng tâm trong 14 ngày tới", string.Join("\r\n", (await Global.LichCongTacNhungNgayToiAsync()).Select(p => $"- {p.ThoiGian?.ToShortDateString()}: {p.NoiDung}")));
        }

        private void giayDiDuongBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //alertControl1.Show(this, "Tiêu đề", "Nội dung");
            new GiayDiDuong.FormNhapThongTinKhoiTao().ShowDialog();
        }

        private void timKiemTepBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new TimKiem.frmTimKiemFileWord(), true);
        }

        private void quanLyCongVanDenBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new CongVan.frmCongVanDen());
        }

        private void btnQuanLyThongTinCanBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new CanBo.FormDanhSachCanBo());
        }

        private void btnBaoCaoDinhKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new CongVan.FormBaoCaoDinhKy());
        }

        private void btnDanhSachXuatCanhTraiPhep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new XuatCanhTraiPhep.FormDanhSachXuatCanhTraiPhep());
        }

        private void btnThongKeXuatCanhTraiPhep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new XuatCanhTraiPhep.FormThongKeXuatCanhTraiPhep());
        }

        private void btnCaiDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new HeThong.FormCaiDat().ShowDialog();
        }

        private void btnTrucTuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new TrucTuan.FormTrucTuan());
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _close = true;
        }

        private void btnLichtrinhCongTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowForm(new LichTrinh.FormLichTrinhCongTac());
        }
    }
}
