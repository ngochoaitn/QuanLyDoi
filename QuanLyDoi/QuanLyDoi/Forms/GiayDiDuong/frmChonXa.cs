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
using QuanLyDoi.Support;
using Aspose.Words;
using System.Diagnostics;
using Aspose.Words.Tables;

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
            txtThang.Text = _thang.ToString();
            txtNam.Text = _nam.ToString();
        }

        private async void frmChonXa_Load(object sender, EventArgs e)
        {
            await HienThiGiaoDien();
           TaoBoSo();
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

        List<GIAY_DI_DUONG> _danhSachGiayDiDuong;
        private void btnXuatGiay_Click(object sender, EventArgs e)
        {
            TaoDanhSachGiayMoi();
            XuatGiay();
        }

        private void TaoDanhSachGiayMoi()
        {
            _danhDauBoSoDaLay.Clear();
            _danhSachGiayDiDuong = new List<GIAY_DI_DUONG>();
            _thang = Convert.ToInt32(txtThang.Text);
            _nam = Convert.ToInt32(txtNam.Text);

            foreach (ChonDiaBanXa chon in chonDiaBanXaBindingSource)
            {
                var boSo = LayMotBoSoNgauNhien();//Sử dụng cho đồng chí này

                int viTriSo = 0;
                while (boSo[viTriSo] == 0)
                    viTriSo++;//Tìm đến tuần cần lấy ngày

                foreach (int id_xa in chon.THU_TU_CHON_XA)
                {
                    GIAY_DI_DUONG giayMoi = new GIAY_DI_DUONG();
                    //giayMoi.ID = SequenceId.GIAY_DI_DUONG().Result;
                    giayMoi.ID_CAN_BO = chon.ID_CAN_BO;
                    giayMoi.ID_DIA_BAN_XA = id_xa;
                    giayMoi.NAM = _nam;
                    giayMoi.THANG = _thang;

                    Tuple<int, int> ngayDiVe = LayNgay(viTriSo++, boSo);
                    giayMoi.NGAY_DI = new DateTime(_nam, _thang, ngayDiVe.Item1);
                    giayMoi.NGAY_VE = new DateTime(_nam, _thang, ngayDiVe.Item2);

                    _danhSachGiayDiDuong.Add(giayMoi);
                }
            }
        }

        private async void XuatGiay()
        {
            Document doc = new Document("Reports\\KeHoachMau.doc");

            doc.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { $"Ngân Sơn, ngày {new DateTime(_nam, _thang, 1).AddMonths(1).AddDays(-1).Day} tháng {_thang} năm {_nam}" });
            doc.MailMerge.Execute(new[] { "Nam" }, new[] { _nam.ToString() });
            doc.MailMerge.Execute(new[] { "Thang" }, new[] { _thang.ToString() });

            Table bang = doc.GetChild(NodeType.Table, 1, true) as Table;
            
            int hangHienTai = 0;
            bang.InsertRows(hangHienTai, hangHienTai, chonDiaBanXaBindingSource.Count - 1);

            var  lstCanBo = await _db.CAN_BO.ToListAsync();

            foreach(var cb in _danhSachGiayDiDuong.GroupBy(p => p.ID_CAN_BO))
            {
                var hang = bang.Rows[hangHienTai];
                string noiDung = "";
                foreach (var cuoc in cb)
                    noiDung += $"- {_lstXa.FirstOrDefault(p => p.ID == cuoc.ID_DIA_BAN_XA)?.ND ?? "" }: từ ngày {cuoc.NGAY_DI?.ToString("dd/MM")} đến ngày {cuoc.NGAY_VE?.ToString("dd/MM/yyyy")}{ControlChar.LineBreak}";
                bang.PutValue(hangHienTai, 1, lstCanBo.FirstOrDefault(p => p.IdCanBo == cb.FirstOrDefault().ID_CAN_BO).HoVaTen);
                bang.PutValue(hangHienTai, 3, noiDung);
                bang.Rows[hangHienTai].ChangeFont(1, bold:true);
                bang.Rows[hangHienTai].ChangeFont(3, italic: true);
                hangHienTai++;
            }

            string noiDUng2 = "";
            foreach(var xa in _danhSachGiayDiDuong.GroupBy(p => p.ID_DIA_BAN_XA))
            {
                foreach (var cb in xa.OrderBy(p => p.NGAY_DI).ThenBy(p => p.NGAY_VE))
                {
                    //Đánh giá xem khả năng trùng đến đâu
                    noiDUng2 += $"- {_lstXa.FirstOrDefault(p => p.ID == cb.ID_DIA_BAN_XA)?.ND ?? "" }: từ ngày {cb.NGAY_DI?.ToString("dd/MM")} đến ngày {cb.NGAY_VE?.ToString("dd/MM/yyyy")}\r\n";
                }
                noiDUng2 += "--------------------------------------------------------\r\n";
            }
            doc.MailMerge.Execute(new[] { "Log" }, new[] { noiDUng2 });

            doc.SaveAndOpenFile($"t{_thang}.doc");
        }

        List<List<int>> _boSo6Tuan = new List<List<int>>();
        List<List<int>> _tuan = new List<List<int>>();
        List<int> _ngayLoaiBo = new List<int>();
        private void TaoBoSo()
        {
            #region Lấy các ngày có thể lấy của các tuần
            DateTime ngayThang = new DateTime(_nam, _thang, 1);
            int ngayCuoiThang = ngayThang.AddMonths(1).AddDays(-1).Day;

            _tuan.Add(new List<int>());//Tạo tuần đầu tiên

            while (ngayThang.Month == _thang)
            {
                if (ngayThang.DayOfWeek == DayOfWeek.Saturday || ngayThang.DayOfWeek == DayOfWeek.Sunday)
                {
                    if (ngayThang.DayOfWeek == DayOfWeek.Saturday)
                        ngayThang = ngayThang.AddDays(2);//để sang thứ 2

                    if (ngayThang.DayOfWeek == DayOfWeek.Sunday)
                        ngayThang = ngayThang.AddDays(1);//để sang thứ 2
                    if (ngayThang.Month != _thang)
                        break;
                    //Sang tuần mới
                    _tuan.Add(new List<int>());
                }

                if (!_ngayLoaiBo.Contains(ngayThang.Day))
                {
                    _tuan.LastOrDefault().Add(ngayThang.Day);
                }
                else
                {
                    #region Các ngày lễ
                    while (_ngayLoaiBo.Contains(ngayThang.Day))
                        ngayThang = ngayThang.AddDays(1);

                    //Nếu gặp ngày lễ coi như thêm 1 tuần
                    _tuan.Add(new List<int>());

                    ngayThang = ngayThang.AddDays(-1);
                    #endregion
                }

                ngayThang = ngayThang.AddDays(1);
            }

            //Thêm cho đủ 6 tuần
            while (_tuan.Count < 6)
                _tuan.Add(new List<int>());
            #endregion

            #region Tạo các trường hợp có thể (phân tích 13 thành 6 số nhỏ hơn bằng 5 (6 tuần, mỗi tuần 5 ngày))
            for (int i6 = 0; i6 <= 5; i6++)
            {
                for (int i5 = 0; i5 <= 5; i5++)
                {
                    for (int i4 = 0; i4 <= 5; i4++)
                    {
                        for (int i3 = 0; i3 <= 5; i3++)
                        {
                            for (int i2 = 0; i2 <= 5; i2++)
                            {
                                for (int i1 = 0; i1 <= 5; i1++)
                                {
                                    if (i1 + i2 + i3 + i4 + i5 + i6 == 13)
                                        _boSo6Tuan.Add(new List<int>() { i1, i2, i3, i4, i5, i6 });
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            #region Loại bỏ các trường hợp không thỏa mãn
            _boSo6Tuan = _boSo6Tuan.Where(p => p.Where(p2 => p2 == 0).Count() == 2).ToList();//Chỉ lấy 4 tuần
            _boSo6Tuan = _boSo6Tuan.Where(p => (p[0] == 0 && p[1] == 0) || (p[4] == 0 && p[5] == 0) || (p[0] ==0 && p[5] == 0)).ToList();//Chỉ lấy 4 tuần => nên 2 tuần phải bằng 0
            //Lấy các số thỏa mãn cho tháng này
            _boSo6Tuan = _boSo6Tuan.Where(p => p[0] <= _tuan[0].Count
                                            && p[1] <= _tuan[1].Count
                                            && p[2] <= _tuan[2].Count
                                            && p[3] <= _tuan[3].Count
                                            && p[4] <= _tuan[4].Count
                                            && p[5] <= _tuan[5].Count
                                            ).ToList();
            #endregion
        }

        List<int> _danhDauBoSoDaLay = new List<int>();
        private List<int> LayMotBoSoNgauNhien()
        {
            Random ran = new Random(_boSo6Tuan.Count);
            int viTri = ran.Next(0, _boSo6Tuan.Count);

            int maxSoLanLay = _danhDauBoSoDaLay.Count / _boSo6Tuan.Count;

            while(_danhDauBoSoDaLay.Count(p => p == viTri) > maxSoLanLay)
                viTri = ran.Next(0, _boSo6Tuan.Count);

            _danhDauBoSoDaLay.Add(viTri);
            return _boSo6Tuan[viTri];
        }

        private void bgrvChonXa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                chonDiaBanXaBindingSource.RemoveCurrent();
        }

        private Tuple<int, int> LayNgay(int vi_tri, List<int> bo_so)
        {
            int soNgayCanLay = bo_so[vi_tri];
            List<Tuple<int, int>> danhSachKhoangCoTheLay = new List<Tuple<int, int>>();
            for(int i = 0; i <= _tuan[vi_tri].Count - soNgayCanLay; i++)
                danhSachKhoangCoTheLay.Add(new Tuple<int, int>(_tuan[vi_tri][i], _tuan[vi_tri][i + soNgayCanLay - 1]));
            //Lấy ngẫu nhiên 1 khoảng
            Random ran = new Random();
            return danhSachKhoangCoTheLay[ran.Next(0, danhSachKhoangCoTheLay.Count)];
        }
    }
}