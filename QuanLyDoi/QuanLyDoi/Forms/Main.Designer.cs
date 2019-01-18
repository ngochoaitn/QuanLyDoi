namespace QuanLyDoi.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.giayDiDuongBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.timKiemTepBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.quanLyCongVanDenBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyThongTinCanBo = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoDinhKy = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
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
            this.btnBaoCaoDinhKy});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý đội";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQuanLyThongTinCanBo);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý cán bộ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.giayDiDuongBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.timKiemTepBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.quanLyCongVanDenBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBaoCaoDinhKy);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tiện ích";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.True;
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý đội";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}

