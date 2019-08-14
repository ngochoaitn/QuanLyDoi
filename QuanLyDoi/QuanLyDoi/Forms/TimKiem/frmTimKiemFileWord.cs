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
using EPocalipse.IFilter;

namespace QuanLyDoi.Forms.TimKiem
{
    public partial class frmTimKiemFileWord : DevExpress.XtraEditors.XtraForm
    {
        List<FileInfo> _lstResult;
        bool _cancel = false;
        MSWordBehavior _msWordBehavior;

        public frmTimKiemFileWord()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _msWordBehavior = new MSWordBehavior();
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
                    if (_cancel)
                    {
                        lblTrangThai.ChangeTextAsync("Đã hủy tìm kiếm", Color.Red);
                        break;
                    }

                    if (file.IsMSWordFile())
                    {
                        Debug.WriteLine($"Tìm File {file.FullName}");
                        try
                        {
                            string allTextLower = "";

                            if (file.Extension.ToLower() == ".doc")
                            {
                                TextReader reader = new FilterReader(file.FullName);
                                using (reader)
                                {
                                    allTextLower = reader.ReadToEnd().ToLower();
                                }
                            }
                            else
                            {
                                allTextLower = _msWordBehavior.ReadAllText(file.FullName).ToLower();
                            }
                            
                            foreach (var w in words)
                            {
                                if (w.Contains("+"))
                                {
                                    var wspl = w.Split('+');
                                    bool found = true;
                                    foreach(var word in wspl)
                                    {
                                        //if (!doc.FindWord(word) && !file.Name.ToLower().Contains(word))
                                        //{
                                        //    found = false;
                                        //    break;
                                        //}

                                        if(!allTextLower.Contains(word.ToLower()) && !file.Name.ToLower().Contains(word))
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
                                    //if (doc.FindWord(w) || file.Name.ToLower().Contains(w))
                                    //{
                                    //    lock (_lstResult)
                                    //    {
                                    //        _lstResult.Add(file);
                                    //        fileInfoBindingSource.Add(file);
                                    //    };
                                    //}

                                    if (allTextLower.Contains(w.ToLower()) || file.Name.ToLower().Contains(w))
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
                            Log.WriteLog($"Lỗi đọc tệp {file.FullName}\r\n{ex.Message}");
                        }
                    }
                }
            }
            catch { }

            foreach (var d in dir.GetDirectories())
                //ThreadPool.QueueUserWorkItem(TimKiemThuMuc, d);
                try
                {
                    if (_cancel)
                    {
                        lblTrangThai.ChangeTextAsync("Đã hủy tìm kiếm", Color.Red);
                        break;
                    }
                    TimKiemThuMuc(d, words);
                }
                catch { }
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            //ThreadPool.QueueUserWorkItem(TimKiemThuMuc, new DirectoryInfo(txtThuMuc.Text));
            //TimKiemThuMuc(new DirectoryInfo(txtThuMuc.Text));
            if (btnTimKiem.Text == "Tìm")
            {
                _cancel = false;
                btnTimKiem.Text = "Dừng";
                _lstResult = new List<FileInfo>();
                //findBackgroundWorker.RunWorkerAsync();
                await this.TimKiemTepAsync();
                //ThreadPool.QueueUserWorkItem(TimKiemThuMuc, new DirectoryInfo(txtThuMuc.Text));
                if (!_cancel)
                    lblTrangThai.ChangeTextAsync("Tìm kiếm hoàn thất", Color.Blue);
                btnTimKiem.ChangeTextAsync("Tìm");
            }
            else
            {
               // findBackgroundWorker.CancelAsync();
                _cancel = true;
                btnTimKiem.ChangeTextAsync("Tìm");
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

        private Task TimKiemTepAsync()
        {
            return Task.Run(() =>
            {
                var words = txtTuKhoa.Text.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var path in txtThuMuc.Text.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                    TimKiemThuMuc(new DirectoryInfo(path?.Trim()), words);
                if (!_cancel)
                    lblTrangThai.ChangeTextAsync("Tìm kiếm hoàn tất", Color.Blue);
                btnTimKiem.ChangeTextAsync("Tìm");
            });
        }

        private void frmTimKiemFileWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            _msWordBehavior?.Dispose();
        }
    }
}