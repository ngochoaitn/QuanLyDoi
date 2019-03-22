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
using DevExpress.XtraCharts;
using QuanLyDoi.Database;
using QuanLyDoi.Lib;
using System.Data.Entity;

namespace QuanLyDoi.Forms.XuatCanhTraiPhep
{
    public partial class FormThongKeXuatCanhTraiPhep : DevExpress.XtraEditors.XtraForm
    {
        QuanLyDoiModel _model;

        public FormThongKeXuatCanhTraiPhep()
        {
            InitializeComponent();
            _model = new QuanLyDoiModel();
        }

        private async Task LoadDuLieu()
        {
            var xctp = await _model.XUAT_CANH_TRAI_PHEP.Where(p => p.NGAY_DI.HasValue
                && p.NGAY_DI.Value >= dateTuNgay.DateTime
                && p.NGAY_DI <= dateDenNgay.DateTime
                && (p.CO_GIAY_THONG_HANH == null || p.CO_GIAY_THONG_HANH == false))
                .OrderBy(p => p.NGAY_DI)
                .ToListAsync();
            
            SetChart(danTocChartControl, xctp.GroupBy(p => p.NGUOI.MA_DAN_TOC)
                .Select(p => new SeriesPoint(p?.FirstOrDefault()?.NGUOI?.MA_DAN_TOC1?.ND ?? "Chưa rõ",
                new[] { (double)p.Count() })).ToList(), ViewType.Pie, "Thống kê theo dân tộc", "{A} = {V}/{TV} lượt");

            SetChart(diaBanChartControl, xctp.GroupBy(p => p.NGUOI?.MA_DIA_BAN_THON1?.MA_DIA_BAN_XA)
                .Select(p => new SeriesPoint(p?.FirstOrDefault()?.NGUOI?.MA_DIA_BAN_THON1?.MA_DIA_BAN_XA.ND ?? "Chưa rõ",
                new[] { (double)p.Count() })).ToList(), ViewType.Pie, "Thống kê theo địa bàn", "{A} = {V}/{TV} lượt");

            SetChart(doTuoiChartControl, DanhSachThang(xctp), ViewType.Pie, "Thống kê theo độ tuổi", "{A} = {V}/{TV} người");

            SetChart(thoiGianChartControl, xctp.GroupBy(p => $"Tháng {p.NGAY_DI?.Month}-{p.NGAY_DI?.Year}")
                .Select(p => new SeriesPoint(p.Key ?? "Chưa rõ",
                new[] { (double)p.Count() })).ToList(), ViewType.Bar, "XCTP", "{A} = {V}/{TV} lượt");

            SetChart(thoiGianChartControl, xctp.Where(p => p.BI_LLCNTQ_BAT.HasValue && p.BI_LLCNTQ_BAT.Value).GroupBy(p => $"Tháng {p.NGAY_DI?.Month}-{p.NGAY_DI?.Year}")
                .Select(p => new SeriesPoint(p.Key ?? "Chưa rõ",
                new[] { (double)p.Count() })).ToList(), ViewType.Bar, "Bị LLCN bắt", "{A} = {V}/{TV} lượt", false);

        }

        private void SetChart(ChartControl chart, List<SeriesPoint> lst_series_points, ViewType type, string name, string tip_pattern, bool clear_before_add=true)
        {
            if (clear_before_add)
                chart.Series.Clear();
            Series series = new Series(name, type);
            series.LegendTextPattern = "{A}";
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;

            series.ToolTipPointPattern = tip_pattern;

            foreach (var sp in lst_series_points)
                series.Points.Add(sp);
            chart.Series.Add(series);
        }

        private List<SeriesPoint> DanhSachThang(List<XUAT_CANH_TRAI_PHEP> lst_xctp)
        {
            List<SeriesPoint> res = new List<SeriesPoint>();
            var lstNamSinh = lst_xctp.Select(p => p.NGUOI).Distinct().Select(p => p.NAM_SINH).Where(p => p.HasValue);
            int namHienTai = DateTime.Now.Year;
            res.Add(new SeriesPoint("Dưới 18", new[] { (double)lstNamSinh.Where(p => namHienTai - p <= 18).Count() }));
            res.Add(new SeriesPoint("Từ 19 đến 25", new[] { (double)lstNamSinh.Where(p =>namHienTai - p >= 19 && namHienTai - p <= 25).Count() }));
            res.Add(new SeriesPoint("Từ 26 đến 33", new[] { (double)lstNamSinh.Where(p => namHienTai - p >= 26 && namHienTai - p <= 33).Count() }));
            res.Add(new SeriesPoint("Từ 34 đến 40", new[] { (double)lstNamSinh.Where(p => namHienTai - p >= 34 && namHienTai - p <= 40).Count() }));
            res.Add(new SeriesPoint("Trên 40", new[] { (double)lstNamSinh.Where(p => namHienTai - p >= 41).Count() }));

            return res;
        }

        private async void FormThongKeXuatCanhTraiPhep_Load(object sender, EventArgs e)
        {
            await LoadDuLieu();

            dateTuNgay.DateTime = new DateTime(DateTime.Now.Year, 01, 01);
            dateDenNgay.DateTime = new DateTime(DateTime.Now.Year, 12, 31);
        }

        private async void btnThongKe_Click(object sender, EventArgs e)
        {
            await this.LoadDuLieu();
        }

        private void chartControl1_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void chartControl1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void chartControl1_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}