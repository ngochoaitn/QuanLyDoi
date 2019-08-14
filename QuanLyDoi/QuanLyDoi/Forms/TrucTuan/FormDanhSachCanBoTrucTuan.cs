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
using QuanLyDoi.Lib;

namespace QuanLyDoi.Forms.TrucTuan
{
    public partial class FormDanhSachCanBoTrucTuan : DevExpress.XtraEditors.XtraForm
    {
        private int _idTrucTuan;
        QuanLyDoiModel _db;
        List<int?> _lstIdCanBo;

        public FormDanhSachCanBoTrucTuan(int id_truc_tuan)
        {
            InitializeComponent();

            _db = new QuanLyDoiModel();

            _idTrucTuan = id_truc_tuan;
        }

        private async Task LoadAndBindingAsync()
        {
            await _db.CAN_BO.LoadAsync();
            cAN_BOBindingSource.DataSource = _db.CAN_BO.Local;
            cAN_BOGridControl.ForceInitialize();

            await _db.TRUC_TUAN_CAN_BO.Where(p => p.IdTrucTuan == _idTrucTuan).LoadAsync();
        }

        private void LoadSelect()
        {
            _lstIdCanBo = _db.TRUC_TUAN_CAN_BO.Local.Select(p => p.IdCanBo).ToList();

            for(int i = 0; i < grvCanBo.RowCount; i++)
            {
                if (_lstIdCanBo.Contains((grvCanBo.GetRow(i) as CAN_BO).IdCanBo))
                    grvCanBo.SelectRow(i);
            }
        }

        private async void FormDanhSachCanBoTrucTuan_Load(object sender, EventArgs e)
        {
            await this.LoadAndBindingAsync();

            grvCanBo.SetGridViewAppearance();

            this.LoadSelect();
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < grvCanBo.RowCount; i++)
            {
                CAN_BO canBo = grvCanBo.GetRow(i) as CAN_BO;
                if (grvCanBo.IsRowSelected(i))
                {
                    if (!_lstIdCanBo.Contains(canBo.IdCanBo))
                    {
                        _db.TRUC_TUAN_CAN_BO.Add(new TRUC_TUAN_CAN_BO()
                        {
                            IdTrucTuan_CanBo = SequenceId.TRUC_TUAN_CAN_BO(),
                            IdTrucTuan = _idTrucTuan,
                            IdCanBo = canBo.IdCanBo
                        });
                    }
                }
                else
                {
                    var delete = _db.TRUC_TUAN_CAN_BO.Local.FirstOrDefault(p => p.IdCanBo == canBo.IdCanBo);
                    if (delete != null)
                        _db.TRUC_TUAN_CAN_BO.Remove(delete);
                }
            }
            await _db.SaveChangesAsync();
            this.DialogResult = DialogResult.OK;
        }
    }
}