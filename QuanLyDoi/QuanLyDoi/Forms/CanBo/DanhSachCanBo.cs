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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using QuanLyDoi.Database;
using System.Data.Entity;

namespace QuanLyDoi.Forms.CanBo
{
    public partial class DanhSachCanBo : XtraForm
    {
        QuanLyDoiModel _db;
        public DanhSachCanBo()
        {
            InitializeComponent();
            _db = new QuanLyDoiModel();
        }

        private void BindingBangMa()
        {
            mACAPBACBindingSource.DataSource = Global.DbBangMa.MA_CAP_BAC.Local;
            mACHUCVUBindingSource.DataSource = Global.DbBangMa.MA_CHUC_VU.Local;
        }

        private async Task LoadAndBindingAsync()
        {
            await _db.CAN_BO.LoadAsync();
            cAN_BOBindingSource.DataSource = _db.CAN_BO.Local;
        }

        private async void DanhSachCanBo_Load(object sender, EventArgs e)
        {
            CustomizeGridview.SetColumnSTT(grvCanBo);
            CustomizeGridview.SetColumnXoa(grvCanBo, XoaCanBo);
            CustomizeGridview.SetGridViewAppearance(grvCanBo, HangThemMoi: false);
            BindingBangMa();
            await LoadAndBindingAsync();
        }

        private async void XoaCanBo(object sender, EventArgs e)
        {
            var canBo = cAN_BOBindingSource.Current as CAN_BO;
            if(canBo != null
                && XtraMessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                cAN_BOBindingSource.RemoveCurrent();
                await _db.SaveChangesAsync();
            }
        }

        private void btnThemCanBo_Click(object sender, EventArgs e)
        {
            CAN_BO canBo = new CAN_BO()
            {
                IdCanBo = SequenceId.CAN_BO(),
                TrinhDoLyLuanChinhTri = "Chưa có",
                TrinhDoNgoaiNgu = "Chưa có",
                TrinhDoTinHoc = "Chưa có"
            };
            cAN_BOBindingSource.Position = cAN_BOBindingSource.Add(canBo);
        }

        private async void DanhSachCanBo_FormClosing(object sender, FormClosingEventArgs e)
        {
            await _db.SaveChangesAsync();
        }
    }
}