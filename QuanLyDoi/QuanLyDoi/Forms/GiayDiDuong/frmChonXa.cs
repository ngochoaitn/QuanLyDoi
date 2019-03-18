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
using QuanLyDoi.Lib;

namespace QuanLyDoi.Forms.GiayDiDuong
{
    public partial class frmChonXa : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _db;
        int _thang, _nam;
        List<int> _cacXaCoDau;
        List<MA_DIA_BAN_XA> _lstXa;
        TaoGiayDiDuong taoGiayDiDuong;

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
            bgrvChonXa.SetGridViewAppearance();
        }

        private void bgrvChonXa_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Name.StartsWith("colID_DIAN_XA"))
            { 
            ChonDiaBanXa chon = bgrvChonXa.GetRow(e.RowHandle) as ChonDiaBanXa;
                if (chon != null)
                {
                    if ((bool)e.Value)
                        chon.THU_TU_CHON_XA.Add(Convert.ToInt32(e.Column.Tag));
                    else
                        chon.THU_TU_CHON_XA.RemoveAll(p => p == Convert.ToInt32(e.Column.Tag));

                    chon.TEN_CAC_XA_DUOC_CHON = "";//Vì cần theo thứ tự string.Join(";", _lstXa.Where(p => chon.THU_TU_CHON_XA.Contains(p.ID)).Select(p => p.ND));

                    foreach (int i in chon.THU_TU_CHON_XA)
                        chon.TEN_CAC_XA_DUOC_CHON += $"{_lstXa.FirstOrDefault(p => p.ID == i)?.ND ?? ""}; ";

                    chonDiaBanXaBindingSource.EndEdit();
                    bgrvChonXa.RefreshData();
                }
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
        private async void btnXuatGiay_Click(object sender, EventArgs e)
        {
            await TaoDanhSachGiayMoi();
            XuatGiay();
        }

        private async Task TaoDanhSachGiayMoi()
        {
            taoGiayDiDuong = new TaoGiayDiDuong(this.LayDanhSachXa(_cacXaCoDau));
            _danhSachGiayDiDuong = new List<GIAY_DI_DUONG>();
            _thang = Convert.ToInt32(txtThang.Text);
            _nam = Convert.ToInt32(txtNam.Text);
            string loi = "";
            foreach (ChonDiaBanXa chon in chonDiaBanXaBindingSource)
            {
                List<MA_DIA_BAN_XA> danhSachXaDuocChonCuaNguoiNay = this.LayDanhSachXa(chon.THU_TU_CHON_XA);
                NhomNgay nhomNgay = new NhomNgay(_thang, _nam, this.LayNgayLoaiBo(chon.NGAY_LOAI_BO));
                chon.GiayDiDuong = new GiayDiDuong(await _db.CAN_BO.FirstAsync(p => p.IdCanBo == chon.ID_CAN_BO), danhSachXaDuocChonCuaNguoiNay);
                try
                {
                    taoGiayDiDuong.DienThongTin(chon.GiayDiDuong, nhomNgay);
                }
                catch
                {
                    loi += $"{chon?.GiayDiDuong?.CanBo?.HoVaTen} không điền được thông tin\r\n";
                }
            }
            if(loi != "")
            {
                ThongBao.BaoLoi(loi);
            }
        }

        private List<MA_DIA_BAN_XA> LayDanhSachXa(List<int> lst_id_xa)
        {
            var res = new List<MA_DIA_BAN_XA>();
            foreach (int id in lst_id_xa)
                res.Add(_lstXa.FirstOrDefault(p => p.ID == id));
            return res;
        }

        private List<int> LayNgayLoaiBo(string ngay_loai_bo)
        {
            var res = new List<int?>();
            if (string.IsNullOrEmpty(ngay_loai_bo))
                return new List<int>();

            foreach (var i in ngay_loai_bo.Split(new[] { ",", ";" }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (i.Contains("-"))
                {
                    var spl = i.Split('-');
                    int? from = spl[0]?.Trim()?.TryConvertToInt32();
                    int? to = spl[1]?.Trim()?.TryConvertToInt32();
                    if (from != null && to != null)
                        for (int fr = from.Value; fr <= to.Value; fr++)
                            res.Add(fr);
                }
                else
                {
                    res.Add(i?.Trim()?.TryConvertToInt32());
                }
            }
            return res.Where(p => p != null).Select(p => p.Value).ToList();
        }

        private string NgayThang(int ngay)
        {
            return $"{ngay.ToString().PadLeft(2, '0')}/{_thang.ToString().PadLeft(2, '0')}";
        }

        private string NgayThangNam(int ngay)
        {
            return $"{ngay.ToString().PadLeft(2, '0')}/{_thang.ToString().PadLeft(2, '0')}/{_nam.ToString().PadLeft(2, '0')}";
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
            foreach(ChonDiaBanXa chon in chonDiaBanXaBindingSource)
            {
                var hang = bang.Rows[hangHienTai];
                string noiDung = "";
                foreach (var cuoc in chon.GiayDiDuong.Cuocs)
                    noiDung += $"- {cuoc?.Xa?.ND ?? "" }: từ ngày {NgayThang(cuoc.TuNgay)} đến ngày {NgayThangNam(cuoc.DenNgay)}{ControlChar.LineBreak}";
                bang.PutValue(hangHienTai, 1, chon.GiayDiDuong.CanBo.HoVaTen);
                bang.PutValue(hangHienTai, 3, noiDung);
                bang.Rows[hangHienTai].ChangeFont(1, bold: true);
                bang.Rows[hangHienTai].ChangeFont(3, italic: true);
                hangHienTai++;
            }

            string log = "";
            foreach (var xa in this.LayDanhSachXa(_cacXaCoDau))
            {
                log += xa.ND + ControlChar.LineBreak;
                foreach (var d in taoGiayDiDuong.ThongKeDiaBanXa[xa])
                {
                    if (d.Value.Count != 0)
                        log += $"Ngày {d.Key.ToString().PadLeft(2, '0')}: {d.Value.Count} đồng chí đến ({string.Join(", ", d.Value.Select(p => p.HoVaTen.Split(' ').Last()))}){ControlChar.LineBreak}";
                }
            }
            
            doc.MailMerge.Execute(new[] { "Log" }, new[] { log });

            doc.SaveAndOpenFile($"t{_thang}.doc");
        }

        private void txtNgayLoai_EditValueChanged(object sender, EventArgs e)
        {
            foreach (ChonDiaBanXa chon in chonDiaBanXaBindingSource)
                chon.NGAY_LOAI_BO = txtNgayLoai.Text;
            chonDiaBanXaBindingSource.EndEdit();
            bgrvChonXa.RefreshData();
        }

        private void bgrvChonXa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                chonDiaBanXaBindingSource.RemoveCurrent();
        }
    }
}