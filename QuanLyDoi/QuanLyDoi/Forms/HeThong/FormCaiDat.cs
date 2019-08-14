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

namespace QuanLyDoi.Forms.HeThong
{
    public partial class FormCaiDat : DevExpress.XtraEditors.XtraForm
    {
        public FormCaiDat()
        {
            InitializeComponent();
        }

        private void btnLuuCaiDat_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ChuoiKetNoiCSDL = txtChuoiKetNoi.Text;
            Properties.Settings.Default.Save();
        }

        private void FormCaiDat_Load(object sender, EventArgs e)
        {
            txtChuoiKetNoi.Text = Properties.Settings.Default.ChuoiKetNoiCSDL;
        }
    }
}