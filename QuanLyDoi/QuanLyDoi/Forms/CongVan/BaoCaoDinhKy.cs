using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDoi.Lib;
using QuanLyDoi.Database;
using System.Data.Entity;

namespace QuanLyDoi.Forms.CongVan
{
    public partial class BaoCaoDinhKy : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _db;
        BAO_CAO_DINH_KY Current { get { return bAO_CAO_DINH_KYBindingSource.Current as BAO_CAO_DINH_KY; } }

        public BaoCaoDinhKy()
        {
            InitializeComponent();
            _db = new QuanLyDoiModel();
        }

        private void BaoCaoDinhKy_Load(object sender, EventArgs e)
        {
            CustomizeGridview.SetGridViewAppearance(grvBaoCaoDinhKy);
            CustomizeGridview.SetGridViewAppearance(grvNgaybaoCao);
        }

        private async void BaoCaoDinhKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            bAO_CAO_DINH_KYBindingSource.EndEdit();
            nGAY_BAO_CAOBindingSource.EndEdit();

            await _db.SaveChangesAsync();
        }

        private void grvBaoCaoDinhKy_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var baoCao = grvBaoCaoDinhKy.GetRow(e.RowHandle) as BAO_CAO_DINH_KY;
            baoCao.IdBaoCaoDinhKy = SequenceId.BAO_CAO_DINH_KY();
            bAO_CAO_DINH_KYBindingSource.EndEdit();
        }

        private void grvNgaybaoCao_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var ngayBaoCao = grvNgaybaoCao.GetRow(e.RowHandle) as BAO_CAO_DINH_KY_NGAY_BAO_CAO;
            ngayBaoCao.Id = SequenceId.BAO_CAO_DINH_KY_NGAY_BAO_CAO();
            ngayBaoCao.IdBaoCaoDinhKy = this.Current.IdBaoCaoDinhKy;
            nGAY_BAO_CAOBindingSource.EndEdit();
        }

        private void bAO_CAO_DINH_KYBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ngayBaoCaoLayoutControlItem.Enabled = bAO_CAO_DINH_KYBindingSource.Count != 0;
        }

        private async void bAO_CAO_DINH_KYBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (this.Current != null)
            {
                lblTrangThai.ChangeTextAsync("Đang tải dữ liệu...", Color.Blue);
                await _db.BAO_CAO_DINH_KY_NGAY_BAO_CAO.Where(p => p.IdBaoCaoDinhKy == this.Current.IdBaoCaoDinhKy).LoadAsync();
                nGAY_BAO_CAOBindingSource.DataSource = _db.BAO_CAO_DINH_KY_NGAY_BAO_CAO.Local.Where(p => p.IdBaoCaoDinhKy == this.Current.IdBaoCaoDinhKy);
                lblTrangThai.ChangeTextAsync("Sẵn sàng", Color.Black);
            }
        }
    }
}