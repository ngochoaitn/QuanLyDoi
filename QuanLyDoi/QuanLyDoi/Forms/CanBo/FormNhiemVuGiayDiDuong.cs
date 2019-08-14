using QuanLyDoi.Database;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace QuanLyDoi.Forms.CanBo
{
    public partial class FormNhiemVuGiayDiDuong : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _context;
        public FormNhiemVuGiayDiDuong()
        {
            _context = new QuanLyDoiModel();
            InitializeComponent();
        }

        private async void FormNhiemVuGiayDiDuong_Load(object sender, EventArgs e)
        {
            await _context.CAN_BO.LoadAsync();
            cAN_BOBindingSource.DataSource = _context.CAN_BO.Local;
        }

        private async void FormNhiemVuGiayDiDuong_FormClosing(object sender, FormClosingEventArgs e)
        {
            cAN_BOBindingSource.EndEdit();
            await _context.SaveChangesAsync();
        }
    }
}