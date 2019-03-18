using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;
using QuanLyDoi.Forms.LamDep;

namespace QuanLyDoi.Lib
{
    class ThongBao
    {
        public static void LuuThanhCong()
        {
            XtraMessageBox.Show("Lưu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, DevExpress.Utils.DefaultBoolean.True);
        }
        public static void LuuThanhCong(string s)
        {
            XtraMessageBox.Show(s, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, DevExpress.Utils.DefaultBoolean.True);
        }
        /// <summary>
        /// OK
        /// </summary>
        /// <param name="s"></param>
        public static void ThongTin(string s)
        {
            XtraMessageBox.Show(s, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information, DevExpress.Utils.DefaultBoolean.True);
        }

        public static void BaoLoiCapNhat(System.Exception ex)
        {
            string s = "";

            if (ex.GetType() == typeof(SqlException))
            {
                SqlException e = (SqlException)ex;
                switch (e.Number)
                {
                    case 207: s = "Không tải được cơ sở dữ liệu hoặc cơ sở dữ liệu đã bị thay đổi cấu trúc";
                        break;
                    case 208: s = "Không tồn tại đối tượng trong cơ sở dữ liệu hoặc không thể tải được dữ liệu";
                        break;
                    case 2627: s = "Bị lỗi trùng khóa chính / chỉ số / ràng buộc dữ liệu";
                        break;
                    case 2601: s = "Bị lỗi trùng khóa chính, ràng buộc dữ liệu";
                        break;
                    case 547: s = "Bản ghi này có liên quan đến các đối tượng khác trong cơ sơ dữ liệu, không thể tác động";
                        break;
                    case 4060: s = "Cơ sở dữ liệu không tồn tại";
                        break;
                    case 18456: s = "Đăng nhập vào cơ sở dữ liệu thất bại";
                        break;
                    case 515: s = "Vui lòng nhập đủ dữ liệu bắt buộc trước khi thực hiện thao tác";
                        break;
                    default: s = "Có lỗi với cơ sở dữ liệu";
                        break;
                }
            }
            else if (ex.GetType() == typeof(NotSupportedException))
            {
                s = "Phương thức không được hỗ trợ bởi hệ thống";
            }
            else if (ex.GetType() == typeof(FileNotFoundException))
            {
                s = "Bị thiếu tập tin nào đó";
            }
            else if (ex.GetType() == typeof(IOException))
            {
                s = "Tập tin đang được mở, vui lòng đóng tập tin rồi thử lại";
            }
            else if (ex.GetType() == typeof(System.ArgumentNullException))
            {
                s = "Tham số truyền vào bị <b>Null</b>";
            }
            else if (ex.GetType() == typeof(System.ArgumentOutOfRangeException) || ex.GetType() == typeof(System.IndexOutOfRangeException))
            {
                s = "Chỉ số của tham số vượt quá giới hạn";
            }
            else if (ex.GetType() == typeof(System.NotImplementedException))
            {
                s = "Thủ tục, hàm hoặc phép tính chưa được định nghĩa";
            }
            else if (ex.GetType() == typeof(System.NullReferenceException))
            {
                s = "Đối tượng <b>Null</b> không thể truy cập";
            }
            else if (ex.GetType() == typeof(System.OutOfMemoryException))
            {
                s = "Không đủ bộ nhớ cho việc thực thi lệnh";
            }
            else if (ex.GetType() == typeof(System.TimeoutException))
            {
                s = "Thời gian tải dữ liệu quá lâu (Time out)";
            }
            else if (ex.GetType() == typeof(System.InvalidOperationException))
            {
                s = "Không thể thực hiện thao tác";
            }
            else
            {
                XtraMessageBox.Show(ex.ToString(), "Chi tiết lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            s += "\n\n Hiển thị chi tiết lỗi?";
            if (XtraMessageBox.Show(s, "Lỗi cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Error, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
                XtraMessageBox.Show(ex.Message, "Chi tiết lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void CanhBao(string noi_dung)
        {
            XtraMessageBox.Show(noi_dung, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, DevExpress.Utils.DefaultBoolean.True);
        }

        public static void BaoLoi(string st)
        {
            XtraMessageBox.Show(st, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error, DevExpress.Utils.DefaultBoolean.True);
        }
        public static void BaoLoiXoa(string st)
        {
            XtraMessageBox.Show(st, "Thông báo lỗi!", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error, DevExpress.Utils.DefaultBoolean.True);
        }

        public static System.Windows.Forms.DialogResult XacNhanLuu()
        {
            DialogResult result = XtraMessageBox.Show("Bạn có muốn lưu tất cả thay đổi?", "Xác nhận!", System.Windows.Forms.MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            return result;
        }
        public static System.Windows.Forms.DialogResult XacNhanXoa()
        {
            DialogResult result = XtraMessageBox.Show("Xác nhận xóa!", "Thông báo!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            return result;
        }
        /// <summary>
        /// Trả về Yes No Cancel
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult XacNhan(string str, MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel)
        {
            DialogResult result = XtraMessageBox.Show(str, "Xác nhận!", buttons, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True);
            return result;
        }
        /// <summary>
        /// Trả về Yes / No
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult XacNhanRutGon(string str)
        {
            DialogResult result = XtraMessageBox.Show(str, "Xác nhận!", System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True);
            return result;
        }

        public static void ShowDangTai()
        {
            try
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(WaitForm1));
            }
            catch { }
        }
        public static void CloseDangTai()
        {
            try
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
            catch { }
        }
        /// <summary>
        /// TT
        /// </summary>
        /// <param name="cap"></param>
        /// <param name="des"></param>
        public static void ThayDoiChuDangTai(string cap = "Vui lòng đợi", string des = "Đang tải", int delay=0)
        {
            try
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption(cap);
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription(des);
                System.Threading.Thread.Sleep(delay);
            }
            catch { }
        }
    }
}
