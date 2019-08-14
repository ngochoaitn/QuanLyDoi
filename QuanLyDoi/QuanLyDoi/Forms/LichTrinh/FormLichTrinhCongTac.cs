using QuanLyDoi.Database;
using QuanLyDoi.Lib;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyDoi.Forms.LichTrinh
{
    public partial class FormLichTrinhCongTac : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _db;

        public FormLichTrinhCongTac()
        {
            InitializeComponent();
            _db = new QuanLyDoiModel();
        }

        private void FormLichTrinhCongTac_Load(object sender, EventArgs e)
        {
            dateTuNgay.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateDenNgay.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            grvLichTrinh
                .AddRowNumber()
                .AddDeleteRowButton(Xoa_LichTrinh)
                .SetGridViewAppearance(HangThemMoi:true, HangThemMoiODau:true);
        }

        private void Xoa_LichTrinh(object sender, EventArgs e)
        {
            LICH_CONG_TAC lichTrinh = lICH_CONG_TACBindingSource.Current as LICH_CONG_TAC;
            if (lichTrinh != null && ThongBao.XacNhan("Xác nhận xóa?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                lICH_CONG_TACBindingSource.RemoveCurrent();
        }

        private async void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            await _db?.SaveChangesAsync();

            btnTaiDuLieu.Enabled = false;

            _db = new QuanLyDoiModel();
            await _db.LICH_CONG_TAC.Where(p => (p.ThoiGian >= dateTuNgay.DateTime && p.ThoiGian <= dateDenNgay.DateTime)
            || (p.DenNgay >= dateTuNgay.DateTime && p.DenNgay <= dateDenNgay.DateTime)).LoadAsync();
            lICH_CONG_TACBindingSource.DataSource = _db.LICH_CONG_TAC.Local;

            btnTaiDuLieu.Enabled = true;
        }

        private async void FormLichTrinhCongTac_FormClosing(object sender, FormClosingEventArgs e)
        {
            lICH_CONG_TACBindingSource.EndEdit();
            await _db.SaveChangesAsync();
        }

        private void grvLichTrinh_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            LICH_CONG_TAC lichTrinh = grvLichTrinh.GetRow(e.RowHandle) as LICH_CONG_TAC;
            lichTrinh.IdLichCongTac = SequenceId.LICH_TRINH_CONG_TAC();
        }
    }
}