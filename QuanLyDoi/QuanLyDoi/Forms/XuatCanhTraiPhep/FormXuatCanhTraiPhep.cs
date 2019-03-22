using QuanLyDoi.Database;
using QuanLyDoi.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoi.Forms.XuatCanhTraiPhep
{
    public partial class FormXuatCanhTraiPhep : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _model, _modelTimKiem;
        public NGUOI NguoiXuatCanh { get; private set; }
        public List<XUAT_CANH_TRAI_PHEP> LstXuatCanhTraiPhep { get; private set; }
        List<NGUOI> _khongCheckNhungNguoiNay;
        bool _khongLuu = false;

        public FormXuatCanhTraiPhep()
        {
            InitializeComponent();
            _model = new QuanLyDoiModel();
            _modelTimKiem = new QuanLyDoiModel();
            _khongCheckNhungNguoiNay = new List<NGUOI>();
            LstXuatCanhTraiPhep = new List<XUAT_CANH_TRAI_PHEP>();
        }

        private void LoadBangMa()
        {
            mADANTOCBindingSource.DataSource = Global.DbBangMa.MA_DAN_TOC.Local;
            mADIABANTHONBindingSource.DataSource = Global.DbBangMa.MA_DIA_BAN_THON.Local;
        }

        private async Task<bool> LuuDuLieu()
        {
            if (_khongLuu)
                return true;

            hO_VA_TENTextBox.Focus();
            gIOI_TINHComboBoxEdit.Focus();

            xUAT_CANH_TRAI_PHEPBindingSource.EndEdit();
            nGUOIBindingSource.EndEdit();
            QuanLyDoiModel temp = new QuanLyDoiModel();
            if (NguoiXuatCanh.ID == 0 && !string.IsNullOrEmpty(NguoiXuatCanh.HO_VA_TEN))
            {
                NguoiXuatCanh.ID = SequenceId.NGUOI();
                temp.NGUOI.Add(NguoiXuatCanh);
                await temp.SaveChangesAsync();
            }

            foreach (XUAT_CANH_TRAI_PHEP xc in xUAT_CANH_TRAI_PHEPBindingSource)
                xc.ID_NGUOI = NguoiXuatCanh.ID;
            try
            {
                await _model.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        bool _finding = false;
        private async Task TimThongTinNguoi()
        {
            if (_finding || _isInit)
                return;

            _finding = true;

            if (!string.IsNullOrEmpty(sO_CMNDTextBox.Text))
            {
                NGUOI checkExist = await _modelTimKiem.NGUOI.FirstOrDefaultAsync(p => p.SO_CMND == sO_CMNDTextBox.Text);
                if (checkExist != null)
                {
                    NguoiXuatCanh = await _model.NGUOI.FirstOrDefaultAsync(p => p.ID == checkExist.ID);
                    nGUOIBindingSource.DataSource = NguoiXuatCanh;
                }
            }
            else if (!string.IsNullOrEmpty(hO_VA_TENTextBox.Text) && !mA_DIA_BAN_THONSearchLookUpEdit.EditValue.EditValueIsNull())
            {
                NGUOI checkExist = await _modelTimKiem.NGUOI.FirstOrDefaultAsync(p => p.HO_VA_TEN.ToLower() == hO_VA_TENTextBox.Text.ToLower() && p.MA_DIA_BAN_THON == mA_DIA_BAN_THONSearchLookUpEdit.EditValue.ToString());
                if (checkExist != null && _khongCheckNhungNguoiNay.FirstOrDefault(p => p.ID == checkExist.ID) == null)
                {
                    switch (ThongBao.XacNhan($"Đã có 01 người có thông tin:\r\nHọ tên: {checkExist.HO_VA_TEN}, sinh ngày {checkExist.NGAY_SINH}/{checkExist.THANG_SNH}/{checkExist.NAM_SINH}\r\nTrú tại: {checkExist?.MA_DIA_BAN_THON1?.ND}\r\n<b>Đồng chí có muốn điền thông tin ngay?</b>"))
                    {
                        case DialogResult.Yes:
                            NguoiXuatCanh = await _model.NGUOI.FirstOrDefaultAsync(p => p.ID == checkExist.ID);
                            nGUOIBindingSource.DataSource = NguoiXuatCanh;
                            break;
                        case DialogResult.No:
                            _khongCheckNhungNguoiNay.Add(checkExist);
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }

            _finding = false;
        }

        bool _isInit = false;
        public async Task InitAsync(int? id_nguoi)
        {
            _isInit = true;
            NguoiXuatCanh = await _model.NGUOI.FirstOrDefaultAsync(p => p.ID == id_nguoi);
            if (NguoiXuatCanh == null)
                NguoiXuatCanh = new NGUOI();
            nGUOIBindingSource.DataSource = NguoiXuatCanh;

            await _model.XUAT_CANH_TRAI_PHEP.Where(p => p.ID_NGUOI == id_nguoi).LoadAsync();
            xUAT_CANH_TRAI_PHEPBindingSource.DataSource = _model.XUAT_CANH_TRAI_PHEP.Local;
            _isInit = false;
        }

        private void FormXuatCanhTraiPhep_Load(object sender, EventArgs e)
        {
            this.LoadBangMa();
            grvXuatCanh.AddDeleteRowButton(Xoa_XuatCanh)
                .AddRowNumber()
                .SetGridViewAppearance(HangThemMoi: true, HangThemMoiODau: true);
            this.ConfirmExit(_model, LuuDuLieu, false, true);
        }

        private void Xoa_XuatCanh(object sender, EventArgs e)
        {
            if (ThongBao.XacNhan("Xóa lần xuất cảnh này?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                xUAT_CANH_TRAI_PHEPBindingSource.RemoveCurrent();
        }

        private async void hO_VA_TENTextBox_EditValueChanged(object sender, EventArgs e)
        {
            await TimThongTinNguoi();
        }

        private async void sO_CMNDTextBox_EditValueChanged(object sender, EventArgs e)
        {
            await TimThongTinNguoi();
        }

        private async void mA_DIA_BAN_THONSearchLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            await TimThongTinNguoi();
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            if (_model.ChangeTracker.HasChanges() && ThongBao.XacNhan("Lưu trước khi nhập mới", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (!await this.LuuDuLieu())
                    return;

            _model = new QuanLyDoiModel();
            NguoiXuatCanh = new NGUOI();
            nGUOIBindingSource.DataSource = NguoiXuatCanh;
            xUAT_CANH_TRAI_PHEPBindingSource.DataSource = _model.XUAT_CANH_TRAI_PHEP.Local;
        }

        private void FormXuatCanhTraiPhep_FormClosing(object sender, FormClosingEventArgs e)
        {
            LstXuatCanhTraiPhep = (xUAT_CANH_TRAI_PHEPBindingSource.List as IList<XUAT_CANH_TRAI_PHEP>).ToList();
        }

        private void btnThoatKhongLuu_Click(object sender, EventArgs e)
        {
            _khongLuu = true;
            this.Close();
        }

        private void grvXuatCanh_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            XUAT_CANH_TRAI_PHEP xctp = grvXuatCanh.GetRow(e.RowHandle) as XUAT_CANH_TRAI_PHEP;
            xctp.ID = SequenceId.XUAT_CANH_TRAI_PHEP();
            xctp.ID_NGUOI = NguoiXuatCanh.ID;
        }
    }
}