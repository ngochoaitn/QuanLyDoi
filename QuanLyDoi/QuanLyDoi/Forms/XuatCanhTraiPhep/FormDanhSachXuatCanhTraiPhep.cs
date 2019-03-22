using QuanLyDoi.Database;
using QuanLyDoi.Lib;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDoi.Forms.XuatCanhTraiPhep
{
    public partial class FormDanhSachXuatCanhTraiPhep : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _model;

        public FormDanhSachXuatCanhTraiPhep()
        {
            InitializeComponent();
            _model = new QuanLyDoiModel();
        }

        private async Task LoadDuLieu()
        {
            _model = new QuanLyDoiModel();
            await _model.XUAT_CANH_TRAI_PHEP.Where(p => p.NGAY_DI.HasValue && p.NGAY_DI.Value >= dateTuNgay.DateTime && p.NGAY_DI <= dateDenNgay.DateTime).LoadAsync();
            xUAT_CANH_TRAI_PHEPBindingSource.DataSource = _model.XUAT_CANH_TRAI_PHEP.Local;
        }

        private async void FormDanhSachXuatCanhTraiPhep_Load(object sender, EventArgs e)
        {
            await this.LoadDuLieu();

            grvXuatCanhTraiPhep.AddRowNumber()
                .SetGridViewAppearance();

            dateTuNgay.DateTime = new DateTime(DateTime.Now.Year, 01, 01);
            dateDenNgay.DateTime = new DateTime(DateTime.Now.Year, 12, 31);
        }

        private async void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            FormXuatCanhTraiPhep frm = new FormXuatCanhTraiPhep();
            await frm.InitAsync(null);
            frm.ShowDialog();

            int pos = xUAT_CANH_TRAI_PHEPBindingSource.Position;
            await this.LoadDuLieu();
            grvXuatCanhTraiPhep.RefreshData();
            xUAT_CANH_TRAI_PHEPBindingSource.Position = pos;
        }

        private async void grvXuatCanhTraiPhep_DoubleClick(object sender, EventArgs e)
        {
            XUAT_CANH_TRAI_PHEP xc = xUAT_CANH_TRAI_PHEPBindingSource.Current as XUAT_CANH_TRAI_PHEP;
            if(xc != null)
            {
                FormXuatCanhTraiPhep frm = new FormXuatCanhTraiPhep();
                await frm.InitAsync(xc.ID_NGUOI);
                frm.ShowDialog();
                int pos = xUAT_CANH_TRAI_PHEPBindingSource.Position;
                await this.LoadDuLieu();
                grvXuatCanhTraiPhep.RefreshData();
                xUAT_CANH_TRAI_PHEPBindingSource.Position = pos;
            }
        }

        private async void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            await this.LoadDuLieu();
        }
    }
}