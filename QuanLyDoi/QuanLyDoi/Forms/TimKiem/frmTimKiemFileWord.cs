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
using System.IO;
using System.Threading;
using QuanLyDoi.Lib;
using Aspose.Words;
using System.Diagnostics;

namespace QuanLyDoi.Forms.TimKiem
{
    public partial class frmTimKiemFileWord : DevExpress.XtraEditors.XtraForm
    {
        public frmTimKiemFileWord()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void TimKiemThuMuc(object obj)
        {
            DirectoryInfo dir = obj as DirectoryInfo;
            Debug.WriteLine($"Tìm thư mục {dir.FullName}");
            try
            {
                Document doc = new Document();
                foreach (var file in dir.GetFiles())
                {
                    if (file.IsMSWordFile())
                    {
                        Debug.WriteLine($"Tìm File {file.FullName}");
                        try
                        {
                            doc = new Document(file.FullName);
                            if (doc.FindWord(txtTuKhoa.Text))
                                fileInfoBindingSource.Add(file);
                        }
                        catch
                        {
                            //fileInfoBindingSource.Add(file);
                        }
                    }
                }
            }
            catch { }

            foreach (var d in dir.GetDirectories())
                //ThreadPool.QueueUserWorkItem(TimKiemThuMuc, d);
                try
                {
                    TimKiemThuMuc(d);
                }
                catch { }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //ThreadPool.QueueUserWorkItem(TimKiemThuMuc, new DirectoryInfo(txtThuMuc.Text));
            TimKiemThuMuc(new DirectoryInfo(txtThuMuc.Text));
        }

        private void btnChonThuMuc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() != DialogResult.Cancel)
                txtThuMuc.Text = folder.SelectedPath;
        }
    }
}