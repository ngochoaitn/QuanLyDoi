using QuanLyDoi.Database;
using QuanLyDoi.Lib;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoi.Forms.CongVan
{
    public partial class FormBaoCaoDinhKy : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _db, _dbNgayBaoCao;
        BAO_CAO_DINH_KY Current { get { return bAO_CAO_DINH_KYBindingSource.Current as BAO_CAO_DINH_KY; } }

        public FormBaoCaoDinhKy()
        {
            InitializeComponent();
            _db = new QuanLyDoiModel();
            _dbNgayBaoCao = new QuanLyDoiModel();
        }

        private async Task LoadAndBindingAsync()
        {
            lblTrangThai.ChangeTextAsync("Đang tải dữ liệu...", Color.Blue);
            await _db.BAO_CAO_DINH_KY.LoadAsync();
            bAO_CAO_DINH_KYBindingSource.DataSource = _db.BAO_CAO_DINH_KY.Local;
            lblTrangThai.ChangeTextAsync("Sẵn sàng", Color.Black);
        }

        private async void BaoCaoDinhKy_Load(object sender, EventArgs e)
        {
            grvBaoCaoDinhKy
                .SetGridViewAppearance()
                .AddDeleteRowButton(Xoa_BaoCaoDinhKy);

            grvNgaybaoCao
                .SetGridViewAppearance()
                .AddDeleteRowButton(Xoa_NgayBaoCao);

            await this.LoadAndBindingAsync();
        }

        private async void Xoa_NgayBaoCao(object sender, EventArgs e)
        {
            BAO_CAO_DINH_KY_NGAY_BAO_CAO baoCao = nGAY_BAO_CAOBindingSource.Current as BAO_CAO_DINH_KY_NGAY_BAO_CAO;
            if (baoCao != null && ThongBao.XacNhan("Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nGAY_BAO_CAOBindingSource.RemoveCurrent();
                await _db.SaveChangesAsync();
            }
        }

        private async void Xoa_BaoCaoDinhKy(object sender, EventArgs e)
        {
            BAO_CAO_DINH_KY baoCao = bAO_CAO_DINH_KYBindingSource.Current as BAO_CAO_DINH_KY;
            if(baoCao != null && ThongBao.XacNhan("Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _db.BAO_CAO_DINH_KY_NGAY_BAO_CAO.RemoveRange(_db.BAO_CAO_DINH_KY_NGAY_BAO_CAO.Where(p => p.IdBaoCaoDinhKy == baoCao.IdBaoCaoDinhKy));
                await _db.SaveChangesAsync();
                bAO_CAO_DINH_KYBindingSource.RemoveCurrent();
                await _db.SaveChangesAsync();
            }
        }

        private async void BaoCaoDinhKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnThemNgayBaoCaoMoi.Focus();
            btnThemBaoCao.Focus();

            bAO_CAO_DINH_KYBindingSource.EndEdit();
            nGAY_BAO_CAOBindingSource.EndEdit();
            await _db.SaveChangesAsync();
            await _dbNgayBaoCao.SaveChangesAsync();
        }

        private void bAO_CAO_DINH_KYBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ngayBaoCaoLayoutControlItem.Enabled = bAO_CAO_DINH_KYBindingSource.Count != 0;
        }

        private async void bAO_CAO_DINH_KYBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (this.Current != null)
            {
                await _dbNgayBaoCao.SaveChangesAsync();

                _dbNgayBaoCao = new QuanLyDoiModel();
                lblTrangThai.ChangeTextAsync("Đang tải dữ liệu...", Color.Blue);
                await _dbNgayBaoCao.BAO_CAO_DINH_KY_NGAY_BAO_CAO.Where(p => p.IdBaoCaoDinhKy == this.Current.IdBaoCaoDinhKy).LoadAsync();
                nGAY_BAO_CAOBindingSource.DataSource = _dbNgayBaoCao.BAO_CAO_DINH_KY_NGAY_BAO_CAO.Local;
                lblTrangThai.ChangeTextAsync("Sẵn sàng", Color.Black);
            }
        }

        private void btnThemBaoCaoMoi_Click(object sender, EventArgs e)
        {
            var baoCao = new BAO_CAO_DINH_KY();
            baoCao.IdBaoCaoDinhKy = SequenceId.BAO_CAO_DINH_KY();
            int pos = bAO_CAO_DINH_KYBindingSource.Add(baoCao);

            _db.SaveChanges();

            bAO_CAO_DINH_KYBindingSource.Position = pos;
        }

        private void btnThemNgayBaoCaoMoi_Click(object sender, EventArgs e)
        {
            var ngayBaoCao = new BAO_CAO_DINH_KY_NGAY_BAO_CAO();
            ngayBaoCao.Id = SequenceId.BAO_CAO_DINH_KY_NGAY_BAO_CAO();
            ngayBaoCao.IdBaoCaoDinhKy = this.Current.IdBaoCaoDinhKy;
            nGAY_BAO_CAOBindingSource.Position = nGAY_BAO_CAOBindingSource.Add(ngayBaoCao);
            nGAY_BAO_CAOBindingSource.EndEdit();
        }
    }
}