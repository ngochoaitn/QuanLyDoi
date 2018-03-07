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
using QuanLyDoi.Database;
using System.Data.Entity;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    public partial class frmChonXa : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _db;
        int _thang, _nam;
        List<int> _cacXaCoDau;
        List<MA_DIA_BAN_XA> _lstXa;

        public frmChonXa(int thang, int nam, List<int> cac_xa_co_dau)
        {
            InitializeComponent();

            _db = new QuanLyDoiModel();

            _thang = thang;
            _nam = nam;
            _cacXaCoDau = cac_xa_co_dau;
        }

        private async void frmChonXa_Load(object sender, EventArgs e)
        {
            await HienThiGiaoDien();
        }

        private void bgrvChonXa_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ChonDiaBanXa chon = bgrvChonXa.GetRow(e.RowHandle) as ChonDiaBanXa;
            if(chon != null)
            {
                if ((bool)e.Value)
                    chon.THU_TU_CHON_XA.Add(Convert.ToInt32(e.Column.Tag));
                else
                    chon.THU_TU_CHON_XA.RemoveAll(p => p == Convert.ToInt32(e.Column.Tag));

                chon.TEN_CAC_XA_DUOC_CHON = "";//Vì cần theo thứ tự string.Join(";", _lstXa.Where(p => chon.THU_TU_CHON_XA.Contains(p.ID)).Select(p => p.ND));

                foreach(int i in chon.THU_TU_CHON_XA)
                    chon.TEN_CAC_XA_DUOC_CHON += $"{_lstXa.FirstOrDefault(p => p.ID == i)?.ND ?? ""}; ";

                chonDiaBanXaBindingSource.EndEdit();
                bgrvChonXa.RefreshData();
            }
        }

        private async Task HienThiGiaoDien()
        {
            _lstXa = await _db.MA_DIA_BAN_XA.ToListAsync();
            for (int i = 0; i < _cacXaCoDau.Count; i++)
            {
                var col = bgrvChonXa.Columns.FirstOrDefault(p => p.Name == $"colID_DIAN_XA_{i + 1}");
                if (col != null)
                {
                    col.Visible = true;
                    col.Caption = _lstXa.FirstOrDefault(p => p.ID == _cacXaCoDau[i])?.ND ?? _cacXaCoDau[i].ToString();
                    col.Tag = _cacXaCoDau[i];
                }
            }

            foreach(var cb in await _db.CAN_BO.ToListAsync())
            {
                ChonDiaBanXa chon = new ChonDiaBanXa();
                chon.ID_CAN_BO = cb.IdCanBo;
                chonDiaBanXaBindingSource.Add(chon);
            }

            cANBOBindingSource.DataSource = _db.CAN_BO.Local;
        }
    }
}