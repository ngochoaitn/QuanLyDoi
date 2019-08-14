using QuanLyDoi.Database;
using QuanLyDoi.Lib;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace QuanLyDoi.Forms.HeThong
{
    public partial class FormIntro : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _db;
        public FormIntro()
        {
            InitializeComponent();
            _db = new QuanLyDoiModel();

            grvLichCongTac
                .AddRowNumber()
                .SetGridViewAppearance();

            grvTrucTuan
                .AddRowNumber()
                .SetGridViewAppearance();
        }

        private async void FormIntro_Load(object sender, EventArgs e)
        {
            //Tải danh sách lịch trình công tác
            lICH_CONG_TACBindingSource.DataSource = await Global.LichCongTacNhungNgayToiAsync();

            //Tải dữ liệu trực tuần
            var trucTuan = await _db.TRUC_TUAN.OrderByDescending(p => p.TuNgay)
                .ThenBy(p => p.DenNgay)
                .FirstOrDefaultAsync();

            if (trucTuan != null)
            {
                lgcTrucTuan.Text = $"Trực từ {trucTuan.TuNgay?.ToShortDateString()} đến {trucTuan.DenNgay?.ToShortDateString()}";
                tRUC_TUAN_CAN_BOBindingSource.DataSource = await _db.TRUC_TUAN_CAN_BO.Where(p => p.IdTrucTuan == trucTuan.IdTrucTuan).ToListAsync();
            }
        }

        private void linkRefresh_Click(object sender, EventArgs e)
        {
            _db = new QuanLyDoiModel();
            this.FormIntro_Load(sender, e);
        }
    }
}