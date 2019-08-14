namespace QuanLyDoi.Forms.CongVan
{
    partial class FormBaoCaoDinhKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCaoDinhKy));
            this.bAO_CAO_DINH_KYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.bAO_CAO_DINH_KYGridControl = new DevExpress.XtraGrid.GridControl();
            this.grvBaoCaoDinhKy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDonViNhanBaoCao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnThemBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.donViNhanBaoCaoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnThemNgayBaoCaoMoi = new DevExpress.XtraEditors.SimpleButton();
            this.lblTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl = new DevExpress.XtraGrid.GridControl();
            this.nGAY_BAO_CAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvNgaybaoCao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soCongVanYeuCauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.noiDungMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ngayBaoCaoLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.bAO_CAO_DINH_KYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAO_CAO_DINH_KYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoDinhKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViNhanBaoCaoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAY_BAO_CAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNgaybaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soCongVanYeuCauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiDungMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBaoCaoLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // bAO_CAO_DINH_KYBindingSource
            // 
            this.bAO_CAO_DINH_KYBindingSource.DataSource = typeof(QuanLyDoi.Database.BAO_CAO_DINH_KY);
            this.bAO_CAO_DINH_KYBindingSource.CurrentChanged += new System.EventHandler(this.bAO_CAO_DINH_KYBindingSource_CurrentChanged);
            this.bAO_CAO_DINH_KYBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bAO_CAO_DINH_KYBindingSource_ListChanged);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(396, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 409);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // bAO_CAO_DINH_KYGridControl
            // 
            this.bAO_CAO_DINH_KYGridControl.DataSource = this.bAO_CAO_DINH_KYBindingSource;
            this.bAO_CAO_DINH_KYGridControl.Location = new System.Drawing.Point(7, 7);
            this.bAO_CAO_DINH_KYGridControl.MainView = this.grvBaoCaoDinhKy;
            this.bAO_CAO_DINH_KYGridControl.Name = "bAO_CAO_DINH_KYGridControl";
            this.bAO_CAO_DINH_KYGridControl.Size = new System.Drawing.Size(382, 352);
            this.bAO_CAO_DINH_KYGridControl.TabIndex = 4;
            this.bAO_CAO_DINH_KYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBaoCaoDinhKy});
            // 
            // grvBaoCaoDinhKy
            // 
            this.grvBaoCaoDinhKy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDonViNhanBaoCao,
            this.colNoiDung});
            this.grvBaoCaoDinhKy.GridControl = this.bAO_CAO_DINH_KYGridControl;
            this.grvBaoCaoDinhKy.Name = "grvBaoCaoDinhKy";
            // 
            // colDonViNhanBaoCao
            // 
            this.colDonViNhanBaoCao.Caption = "Đơn vị nhận báo cáo";
            this.colDonViNhanBaoCao.FieldName = "DonViNhanBaoCao";
            this.colDonViNhanBaoCao.Name = "colDonViNhanBaoCao";
            this.colDonViNhanBaoCao.Visible = true;
            this.colDonViNhanBaoCao.VisibleIndex = 0;
            // 
            // colNoiDung
            // 
            this.colNoiDung.Caption = "Nội dung";
            this.colNoiDung.FieldName = "NoiDung";
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.Visible = true;
            this.colNoiDung.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem8});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(396, 409);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.bAO_CAO_DINH_KYGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(386, 356);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnThemBaoCao;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 356);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(97, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnThemBaoCao
            // 
            this.btnThemBaoCao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemBaoCao.Appearance.Options.UseFont = true;
            this.btnThemBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemBaoCao.ImageOptions.Image")));
            this.btnThemBaoCao.Location = new System.Drawing.Point(7, 363);
            this.btnThemBaoCao.Name = "btnThemBaoCao";
            this.btnThemBaoCao.Size = new System.Drawing.Size(93, 22);
            this.btnThemBaoCao.StyleController = this.layoutControl1;
            this.btnThemBaoCao.TabIndex = 5;
            this.btnThemBaoCao.Text = "Thêm mới";
            this.btnThemBaoCao.Click += new System.EventHandler(this.btnThemBaoCaoMoi_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.btnThemBaoCao);
            this.layoutControl1.Controls.Add(this.bAO_CAO_DINH_KYGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(631, 183, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(396, 409);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 389);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(382, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 6;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(97, 356);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(289, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.labelControl1;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 382);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(386, 17);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.ngayBaoCaoLayoutControlItem,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup2.Size = new System.Drawing.Size(454, 409);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.donViNhanBaoCaoTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(222, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(222, 40);
            this.layoutControlItem3.Text = "Đơn vị nhận báo cáo";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(141, 13);
            // 
            // donViNhanBaoCaoTextEdit
            // 
            this.donViNhanBaoCaoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bAO_CAO_DINH_KYBindingSource, "DonViNhanBaoCao", true));
            this.donViNhanBaoCaoTextEdit.Location = new System.Drawing.Point(229, 23);
            this.donViNhanBaoCaoTextEdit.Name = "donViNhanBaoCaoTextEdit";
            this.donViNhanBaoCaoTextEdit.Size = new System.Drawing.Size(218, 20);
            this.donViNhanBaoCaoTextEdit.StyleController = this.layoutControl2;
            this.donViNhanBaoCaoTextEdit.TabIndex = 5;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnThemNgayBaoCaoMoi);
            this.layoutControl2.Controls.Add(this.lblTrangThai);
            this.layoutControl2.Controls.Add(this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl);
            this.layoutControl2.Controls.Add(this.soCongVanYeuCauTextEdit);
            this.layoutControl2.Controls.Add(this.noiDungMemoEdit);
            this.layoutControl2.Controls.Add(this.donViNhanBaoCaoTextEdit);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(401, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(724, 163, 650, 400);
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(454, 409);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btnThemNgayBaoCaoMoi
            // 
            this.btnThemNgayBaoCaoMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemNgayBaoCaoMoi.Appearance.Options.UseFont = true;
            this.btnThemNgayBaoCaoMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNgayBaoCaoMoi.ImageOptions.Image")));
            this.btnThemNgayBaoCaoMoi.Location = new System.Drawing.Point(7, 363);
            this.btnThemNgayBaoCaoMoi.Name = "btnThemNgayBaoCaoMoi";
            this.btnThemNgayBaoCaoMoi.Size = new System.Drawing.Size(90, 22);
            this.btnThemNgayBaoCaoMoi.StyleController = this.layoutControl2;
            this.btnThemNgayBaoCaoMoi.TabIndex = 9;
            this.btnThemNgayBaoCaoMoi.Text = "Thêm mới";
            this.btnThemNgayBaoCaoMoi.Click += new System.EventHandler(this.btnThemNgayBaoCaoMoi_Click);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Location = new System.Drawing.Point(7, 389);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(44, 13);
            this.lblTrangThai.StyleController = this.layoutControl2;
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Sẵn sàng";
            // 
            // bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl
            // 
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.DataSource = this.nGAY_BAO_CAOBindingSource;
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.Location = new System.Drawing.Point(7, 158);
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.MainView = this.grvNgaybaoCao;
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.Name = "bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl";
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.Size = new System.Drawing.Size(440, 201);
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.TabIndex = 7;
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNgaybaoCao});
            // 
            // nGAY_BAO_CAOBindingSource
            // 
            this.nGAY_BAO_CAOBindingSource.DataSource = typeof(QuanLyDoi.Database.BAO_CAO_DINH_KY_NGAY_BAO_CAO);
            // 
            // grvNgaybaoCao
            // 
            this.grvNgaybaoCao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgay,
            this.colThang,
            this.colGhiChu});
            this.grvNgaybaoCao.GridControl = this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl;
            this.grvNgaybaoCao.Name = "grvNgaybaoCao";
            // 
            // colNgay
            // 
            this.colNgay.AppearanceCell.Options.UseTextOptions = true;
            this.colNgay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.MaxWidth = 65;
            this.colNgay.MinWidth = 55;
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 0;
            this.colNgay.Width = 63;
            // 
            // colThang
            // 
            this.colThang.AppearanceCell.Options.UseTextOptions = true;
            this.colThang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThang.Caption = "Tháng";
            this.colThang.FieldName = "Thang";
            this.colThang.MaxWidth = 65;
            this.colThang.MinWidth = 55;
            this.colThang.Name = "colThang";
            this.colThang.Visible = true;
            this.colThang.VisibleIndex = 1;
            this.colThang.Width = 62;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            this.colGhiChu.Width = 297;
            // 
            // soCongVanYeuCauTextEdit
            // 
            this.soCongVanYeuCauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bAO_CAO_DINH_KYBindingSource, "SoCongVanYeuCau", true));
            this.soCongVanYeuCauTextEdit.Location = new System.Drawing.Point(7, 23);
            this.soCongVanYeuCauTextEdit.Name = "soCongVanYeuCauTextEdit";
            this.soCongVanYeuCauTextEdit.Size = new System.Drawing.Size(218, 20);
            this.soCongVanYeuCauTextEdit.StyleController = this.layoutControl2;
            this.soCongVanYeuCauTextEdit.TabIndex = 7;
            // 
            // noiDungMemoEdit
            // 
            this.noiDungMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bAO_CAO_DINH_KYBindingSource, "NoiDung", true));
            this.noiDungMemoEdit.Location = new System.Drawing.Point(7, 63);
            this.noiDungMemoEdit.Name = "noiDungMemoEdit";
            this.noiDungMemoEdit.Size = new System.Drawing.Size(440, 75);
            this.noiDungMemoEdit.StyleController = this.layoutControl2;
            this.noiDungMemoEdit.TabIndex = 6;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.noiDungMemoEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(444, 95);
            this.layoutControlItem4.Text = "Nội dung";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(141, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.soCongVanYeuCauTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(222, 40);
            this.layoutControlItem5.Text = "Số, ký hiệu công văn yêu cầu";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(141, 13);
            // 
            // ngayBaoCaoLayoutControlItem
            // 
            this.ngayBaoCaoLayoutControlItem.Control = this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl;
            this.ngayBaoCaoLayoutControlItem.Enabled = false;
            this.ngayBaoCaoLayoutControlItem.Location = new System.Drawing.Point(0, 135);
            this.ngayBaoCaoLayoutControlItem.Name = "ngayBaoCaoLayoutControlItem";
            this.ngayBaoCaoLayoutControlItem.Size = new System.Drawing.Size(444, 221);
            this.ngayBaoCaoLayoutControlItem.Text = "Thời gian báo cáo";
            this.ngayBaoCaoLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.ngayBaoCaoLayoutControlItem.TextSize = new System.Drawing.Size(141, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lblTrangThai;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 382);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(444, 17);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnThemNgayBaoCaoMoi;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 356);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(94, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(94, 356);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(350, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormBaoCaoDinhKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 409);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormBaoCaoDinhKy";
            this.Text = "Báo cáo định kỳ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaoCaoDinhKy_FormClosing);
            this.Load += new System.EventHandler(this.BaoCaoDinhKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAO_CAO_DINH_KYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAO_CAO_DINH_KYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoDinhKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViNhanBaoCaoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAY_BAO_CAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNgaybaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soCongVanYeuCauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiDungMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBaoCaoLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bAO_CAO_DINH_KYBindingSource;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl bAO_CAO_DINH_KYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBaoCaoDinhKy;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViNhanBaoCao;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiDung;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit donViNhanBaoCaoTextEdit;
        private DevExpress.XtraEditors.TextEdit soCongVanYeuCauTextEdit;
        private DevExpress.XtraEditors.MemoEdit noiDungMemoEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl;
        private System.Windows.Forms.BindingSource nGAY_BAO_CAOBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNgaybaoCao;
        private DevExpress.XtraLayout.LayoutControlItem ngayBaoCaoLayoutControlItem;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colThang;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.LabelControl lblTrangThai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnThemBaoCao;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton btnThemNgayBaoCaoMoi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}