using QuanLyDoi.Database;
using QuanLyDoi.Lib;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoi.Forms.CongVan
{
    public partial class frmCongVanDen : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _context, _category;
        public frmCongVanDen()
        {
            InitializeComponent();
            _context = new QuanLyDoiModel();
            _category = new QuanLyDoiModel();
        }

        private async Task LoadAndBindingCategoryAsync()
        {
            //await _context.CONG_VAN.LoadAsync();
            mALOAICONGVANBindingSource.DataSource = await _category.MA_LOAI_CONG_VAN.ToListAsync();
        }

        private async void frmCongVanDen_Load(object sender, EventArgs e)
        {
            await LoadAndBindingCategoryAsync();

            cbbNam.SelectedValueChanged -= cbbNam_SelectedIndexChanged;
            for (int nam = 2019; nam <= DateTime.Now.Year; nam++)
                cbbNam.Properties.Items.Add(nam);
            cbbNam.SelectedValueChanged += cbbNam_SelectedIndexChanged;
            cbbNam.SelectedItem = DateTime.Now.Year;

            grvCongVan.AddRowNumber()
                .AddDeleteRowButton(Xoa_CongVanDen)
                .SetGridViewAppearance(HangThemMoi:true, HangThemMoiODau:true);
        }

        private void Xoa_CongVanDen(object sender, EventArgs e)
        {
            if(ThongBao.XacNhan("Xác nhận xóa công văn đến?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                cONG_VANBindingSource.RemoveCurrent();
        }

        private async void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _context.SaveChangesAsync();
            _context = new QuanLyDoiModel();
            _context = new QuanLyDoiModel();
            cbbNam.Enabled = false;
            cbbNam.SelectedValueChanged -= cbbNam_SelectedIndexChanged;

            await _context.CONG_VAN
                .Where(p => p.NgayNhan.HasValue && p.NgayNhan.Value.Year == (int)cbbNam.SelectedItem)
                .LoadAsync();

            cONG_VANBindingSource.DataSource = _context.CONG_VAN.Local;//.Where(p => p.NgayNhan.HasValue && p.NgayNhan.Value.Year == (int)cbbNam.SelectedItem);

            cbbNam.SelectedValueChanged += cbbNam_SelectedIndexChanged;
            cbbNam.Enabled = true;
        }

        private async void frmCongVanDen_FormClosing(object sender, FormClosingEventArgs e)
        {
            await _context.SaveChangesAsync();
        }

        private void grvCongVan_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            CONG_VAN cv = grvCongVan.GetRow(e.RowHandle) as CONG_VAN;
            if(cv != null)
            {
                cv.IdCongVan = SequenceId.CONG_VAN();
                cv.NgayNhan = DateTime.Now;
            }
        }
    }
}