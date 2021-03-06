﻿namespace QuanLyDoi.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.giayDiDuongBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.timKiemTepBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.quanLyCongVanDenBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyThongTinCanBo = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoDinhKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachXuatCanhTraiPhep = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeXuatCanhTraiPhep = new DevExpress.XtraBars.BarButtonItem();
            this.btnCaiDat = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrucTuan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btnLichtrinhCongTac = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.giayDiDuongBarButtonItem,
            this.timKiemTepBarButtonItem,
            this.quanLyCongVanDenBarButtonItem,
            this.btnQuanLyThongTinCanBo,
            this.btnBaoCaoDinhKy,
            this.btnDanhSachXuatCanhTraiPhep,
            this.btnThongKeXuatCanhTraiPhep,
            this.btnCaiDat,
            this.btnTrucTuan,
            this.btnLichtrinhCongTac});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(838, 143);
            // 
            // giayDiDuongBarButtonItem
            // 
            this.giayDiDuongBarButtonItem.Caption = "Giấy đi đường";
            this.giayDiDuongBarButtonItem.Id = 1;
            this.giayDiDuongBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("giayDiDuongBarButtonItem.ImageOptions.Image")));
            this.giayDiDuongBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("giayDiDuongBarButtonItem.ImageOptions.LargeImage")));
            this.giayDiDuongBarButtonItem.Name = "giayDiDuongBarButtonItem";
            this.giayDiDuongBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.giayDiDuongBarButtonItem_ItemClick);
            // 
            // timKiemTepBarButtonItem
            // 
            this.timKiemTepBarButtonItem.Caption = "Tìm kiếm tệp";
            this.timKiemTepBarButtonItem.Id = 3;
            this.timKiemTepBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("timKiemTepBarButtonItem.ImageOptions.Image")));
            this.timKiemTepBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("timKiemTepBarButtonItem.ImageOptions.LargeImage")));
            this.timKiemTepBarButtonItem.Name = "timKiemTepBarButtonItem";
            this.timKiemTepBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.timKiemTepBarButtonItem_ItemClick);
            // 
            // quanLyCongVanDenBarButtonItem
            // 
            this.quanLyCongVanDenBarButtonItem.Caption = "Quản lý công văn đến";
            this.quanLyCongVanDenBarButtonItem.Id = 4;
            this.quanLyCongVanDenBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("quanLyCongVanDenBarButtonItem.ImageOptions.Image")));
            this.quanLyCongVanDenBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("quanLyCongVanDenBarButtonItem.ImageOptions.LargeImage")));
            this.quanLyCongVanDenBarButtonItem.Name = "quanLyCongVanDenBarButtonItem";
            this.quanLyCongVanDenBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.quanLyCongVanDenBarButtonItem_ItemClick);
            // 
            // btnQuanLyThongTinCanBo
            // 
            this.btnQuanLyThongTinCanBo.Caption = "Quản lý thông tin cán bộ";
            this.btnQuanLyThongTinCanBo.Id = 5;
            this.btnQuanLyThongTinCanBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyThongTinCanBo.ImageOptions.Image")));
            this.btnQuanLyThongTinCanBo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyThongTinCanBo.ImageOptions.LargeImage")));
            this.btnQuanLyThongTinCanBo.Name = "btnQuanLyThongTinCanBo";
            this.btnQuanLyThongTinCanBo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyThongTinCanBo_ItemClick);
            // 
            // btnBaoCaoDinhKy
            // 
            this.btnBaoCaoDinhKy.Caption = "Danh sách báo cáo định kỳ";
            this.btnBaoCaoDinhKy.Id = 6;
            this.btnBaoCaoDinhKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoDinhKy.ImageOptions.Image")));
            this.btnBaoCaoDinhKy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoDinhKy.ImageOptions.LargeImage")));
            this.btnBaoCaoDinhKy.Name = "btnBaoCaoDinhKy";
            this.btnBaoCaoDinhKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCaoDinhKy_ItemClick);
            // 
            // btnDanhSachXuatCanhTraiPhep
            // 
            this.btnDanhSachXuatCanhTraiPhep.Caption = "Xuất cảnh trái phép";
            this.btnDanhSachXuatCanhTraiPhep.Id = 7;
            this.btnDanhSachXuatCanhTraiPhep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachXuatCanhTraiPhep.ImageOptions.Image")));
            this.btnDanhSachXuatCanhTraiPhep.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDanhSachXuatCanhTraiPhep.ImageOptions.LargeImage")));
            this.btnDanhSachXuatCanhTraiPhep.Name = "btnDanhSachXuatCanhTraiPhep";
            this.btnDanhSachXuatCanhTraiPhep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachXuatCanhTraiPhep_ItemClick);
            // 
            // btnThongKeXuatCanhTraiPhep
            // 
            this.btnThongKeXuatCanhTraiPhep.Caption = "Thống kê xuất cảnh trái phép";
            this.btnThongKeXuatCanhTraiPhep.Id = 8;
            this.btnThongKeXuatCanhTraiPhep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKeXuatCanhTraiPhep.ImageOptions.Image")));
            this.btnThongKeXuatCanhTraiPhep.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongKeXuatCanhTraiPhep.ImageOptions.LargeImage")));
            this.btnThongKeXuatCanhTraiPhep.Name = "btnThongKeXuatCanhTraiPhep";
            this.btnThongKeXuatCanhTraiPhep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKeXuatCanhTraiPhep_ItemClick);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Caption = "Cài đặt";
            this.btnCaiDat.Id = 9;
            this.btnCaiDat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCaiDat.ImageOptions.Image")));
            this.btnCaiDat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCaiDat.ImageOptions.LargeImage")));
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCaiDat_ItemClick);
            // 
            // btnTrucTuan
            // 
            this.btnTrucTuan.Caption = "Trực tuần";
            this.btnTrucTuan.Id = 10;
            this.btnTrucTuan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrucTuan.ImageOptions.Image")));
            this.btnTrucTuan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTrucTuan.ImageOptions.LargeImage")));
            this.btnTrucTuan.Name = "btnTrucTuan";
            this.btnTrucTuan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrucTuan_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý đội";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQuanLyThongTinCanBo);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTrucTuan);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLichtrinhCongTac);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý cán bộ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhSachXuatCanhTraiPhep);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThongKeXuatCanhTraiPhep);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Xuất nhập cảnh";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.giayDiDuongBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.timKiemTepBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.quanLyCongVanDenBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBaoCaoDinhKy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCaiDat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tiện ích";
            // 
            // alertControl1
            // 
            this.alertControl1.AutoHeight = true;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.True;
            // 
            // btnLichtrinhCongTac
            // 
            this.btnLichtrinhCongTac.Caption = "Lịch trình công tác";
            this.btnLichtrinhCongTac.Id = 11;
            this.btnLichtrinhCongTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnLichtrinhCongTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnLichtrinhCongTac.Name = "btnLichtrinhCongTac";
            this.btnLichtrinhCongTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLichtrinhCongTac_ItemClick);
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 360);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý đội";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem giayDiDuongBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem timKiemTepBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem quanLyCongVanDenBarButtonItem;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyThongTinCanBo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoDinhKy;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachXuatCanhTraiPhep;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnThongKeXuatCanhTraiPhep;
        private DevExpress.XtraBars.BarButtonItem btnCaiDat;
        private DevExpress.XtraBars.BarButtonItem btnTrucTuan;
        private DevExpress.XtraBars.BarButtonItem btnLichtrinhCongTac;
    }
}

