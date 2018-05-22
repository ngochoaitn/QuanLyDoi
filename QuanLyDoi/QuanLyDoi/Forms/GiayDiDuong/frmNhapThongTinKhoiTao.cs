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
using DevExpress.XtraLayout;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    public partial class frmNhapThongTinKhoiTao : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _db;
        List<int> cacXaDuocChon = new List<int>();

        public frmNhapThongTinKhoiTao()
        {
            InitializeComponent();
            _db = new QuanLyDoiModel();
        }

        private async void frmNhapThongTinKhoiTao_Load(object sender, EventArgs e)
        {
            txtThang.Text = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();

            await HienThiCheckBoxCacXa();
        }

        private async Task HienThiCheckBoxCacXa()
        {
            foreach(var xa in await _db.MA_DIA_BAN_XA.ToListAsync())
            {
                LayoutControlItem li = new LayoutControlItem();
                li.TextVisible = false;
                groupCheckXa.AddItem(li);

                CheckEdit check = new CheckEdit();
                check.Text = xa.ND;
                check.Tag = xa.ID;
                check.CheckedChanged += (s1, e1) =>
                {
                    if (check.Checked)
                        cacXaDuocChon.Add(Convert.ToInt32(check.Tag));
                    else
                        cacXaDuocChon.RemoveAll(p => p == Convert.ToInt32(check.Tag));
                };

                this.layoutControl1.Controls.Add(check);
                li.Control = check;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //foreach(var l in groupCheckXa.Items)
            //{
            //    if(l is LayoutControlItem)
            //    {
            //        if ((l as LayoutControlItem).Control is CheckEdit)
            //        {
            //            var check = (l as LayoutControlItem).Control as CheckEdit;
            //            if (check.Checked)
            //                cacXaDuocChon.Add(Convert.ToInt32(check.Tag));
            //        }
            //    }
            //}
            int thang = Convert.ToInt32(txtThang.Text);
            int nam = Convert.ToInt32(txtNam.Text);

            new frmChonXa(thang, nam, cacXaDuocChon).Show();
        }
    }
}