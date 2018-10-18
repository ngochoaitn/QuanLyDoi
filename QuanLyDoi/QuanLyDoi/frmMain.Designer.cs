namespace QuanLyDoi
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.giayDiDuongBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.timKiemTepBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.quanLyCongVanDenBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.giayDiDuongBarButtonItem,
            this.timKiemTepBarButtonItem,
            this.quanLyCongVanDenBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.giayDiDuongBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.timKiemTepBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.quanLyCongVanDenBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
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
    }
}

