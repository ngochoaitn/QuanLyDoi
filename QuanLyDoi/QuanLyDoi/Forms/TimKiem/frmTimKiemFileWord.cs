﻿using System;
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
        List<FileInfo> _lstResult;
        public frmTimKiemFileWord()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void TimKiemThuMuc(DirectoryInfo dir, List<string> words)
        {
            if (!dir.Exists)
                return;
            //Debug.WriteLine($"Tìm thư mục {dir.FullName}");
            lblTrangThai.ChangeTextAsync($"Tìm thư mục {dir.FullName}", Color.Blue);
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
                            foreach (var w in words)
                            {
                                if (w.Contains("+"))
                                {
                                    var wspl = w.Split('+');
                                    bool found = true;
                                    foreach(var word in wspl)
                                    {
                                        if (!doc.FindWord(word) && !file.Name.ToLower().Contains(word))
                                        {
                                            found = false;
                                            break;
                                        }
                                    }
                                    if(found)
                                    {
                                        lock (_lstResult)
                                        {
                                            _lstResult.Add(file);
                                            fileInfoBindingSource.Add(file);
                                        };
                                    }
                                }
                                else
                                {
                                    if (doc.FindWord(w) || file.Name.ToLower().Contains(w))
                                    {
                                        lock (_lstResult)
                                        {
                                            _lstResult.Add(file);
                                            fileInfoBindingSource.Add(file);
                                        };
                                    }
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            Debug.WriteLine($"Lỗi: {file.FullName}\r\n{ex.Message}");
                        }
                    }
                }
            }
            catch { }

            foreach (var d in dir.GetDirectories())
                //ThreadPool.QueueUserWorkItem(TimKiemThuMuc, d);
                try
                {
                    TimKiemThuMuc(d, words);
                }
                catch { }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //ThreadPool.QueueUserWorkItem(TimKiemThuMuc, new DirectoryInfo(txtThuMuc.Text));
            //TimKiemThuMuc(new DirectoryInfo(txtThuMuc.Text));
            if (btnTimKiem.Text == "Tìm")
            {
                btnTimKiem.Text = "Dừng";
                _lstResult = new List<FileInfo>();
                findBackgroundWorker.RunWorkerAsync();
                //ThreadPool.QueueUserWorkItem(TimKiemThuMuc, new DirectoryInfo(txtThuMuc.Text));
                lblTrangThai.ChangeTextAsync("Tìm kiếm hoàn thất", Color.Blue);
            }
            else
            {
                findBackgroundWorker.CancelAsync();
            }
        }

        private void btnChonThuMuc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() != DialogResult.Cancel)
                txtThuMuc.Text = folder.SelectedPath;
        }

        private void grvFileInfo_DoubleClick(object sender, EventArgs e)
        {
            FileInfo file = fileInfoBindingSource.Current as FileInfo;
            if (file != null)
                Process.Start(file.FullName);
        }

        private void findBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var words = txtTuKhoa.Text.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var path in txtThuMuc.Text.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                TimKiemThuMuc(new DirectoryInfo(path?.Trim()), words);
        }

        private void findBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblTrangThai.ChangeTextAsync("Tìm kiếm hoàn tất", Color.Blue);
        }
    }
}