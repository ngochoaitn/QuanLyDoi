using QuanLyDoi.Database;
using QuanLyDoi.Lib;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoi.Forms.TrucTuan
{
    public partial class FormTrucTuan : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _dbTrucTuan, _dbCanBoTrucTuan;
        public FormTrucTuan()
        {
            InitializeComponent();
            _dbTrucTuan = new QuanLyDoiModel();
            _dbCanBoTrucTuan = new QuanLyDoiModel();
        }

        private async Task LoadAndBindingAsync()
        {
            await _dbTrucTuan.TRUC_TUAN.LoadAsync();
            tRUC_TUANBindingSource.DataSource = _dbTrucTuan.TRUC_TUAN.Local;
        }

        private void tRUC_TUANBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            _dbCanBoTrucTuan.SaveChanges();

            _dbCanBoTrucTuan = new QuanLyDoiModel();
            TRUC_TUAN trucTuan = tRUC_TUANBindingSource.Current as TRUC_TUAN;
            if(trucTuan != null)
            {
                _dbCanBoTrucTuan.TRUC_TUAN_CAN_BO.Where(p => p.IdTrucTuan == trucTuan.IdTrucTuan).Load();
                tRUC_TUAN_CAN_BOBindingSource.DataSource = _dbCanBoTrucTuan.TRUC_TUAN_CAN_BO.Local;
            }
        }

        private async void FormTrucTuan_Load(object sender, EventArgs e)
        {
            await this.LoadAndBindingAsync();

            grvTrucTuan.AddRowNumber()
                .AddDeleteRowButton(Xoa_TrucTuan)
                .SetGridViewAppearance();

            grvCanBoTrucTuan.AddRowNumber()
                .AddDeleteRowButton(Xoa_CanBoTrucTuan)
                .SetGridViewAppearance();
        }

        private async void Xoa_CanBoTrucTuan(object sender, EventArgs e)
        {
            TRUC_TUAN trucTuan = tRUC_TUANBindingSource.Current as TRUC_TUAN;
            if (trucTuan != null && ThongBao.XacNhan("Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tRUC_TUANBindingSource.RemoveCurrent();
                await _dbTrucTuan.SaveChangesAsync();
            }
        }

        private void btnQuanLyCanBo_Click(object sender, EventArgs e)
        {
            TRUC_TUAN trucTuan = tRUC_TUANBindingSource.Current as TRUC_TUAN;
            if (trucTuan != null)
            {
                _dbTrucTuan.SaveChanges();
                if (new FormDanhSachCanBoTrucTuan(trucTuan.IdTrucTuan).ShowDialog() == DialogResult.OK)
                {
                    tRUC_TUANBindingSource_CurrentChanged(sender, e);
                }
            }
        }

        private void btnThemTuanMoi_Click(object sender, EventArgs e)
        {
            tRUC_TUANBindingSource.Position = tRUC_TUANBindingSource.Add(new TRUC_TUAN()
            {
                IdTrucTuan = SequenceId.TRUC_TUAN(),
                TuNgay = DateTime.Now, 
                DenNgay = DateTime.Now.AddDays(7)
            });
        }

        private async void Xoa_TrucTuan(object sender, EventArgs e)
        {
            TRUC_TUAN trucTuan = tRUC_TUANBindingSource.Current as TRUC_TUAN;
            if (trucTuan != null && ThongBao.XacNhan("Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _dbCanBoTrucTuan.TRUC_TUAN_CAN_BO.RemoveRange(_dbCanBoTrucTuan.TRUC_TUAN_CAN_BO.Where(p => p.IdTrucTuan == trucTuan.IdTrucTuan));
                tRUC_TUANBindingSource.RemoveCurrent();

                await _dbCanBoTrucTuan.SaveChangesAsync();
                await _dbTrucTuan.SaveChangesAsync();
            }
        }
    }
}
