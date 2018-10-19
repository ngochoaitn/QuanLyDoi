namespace QuanLyDoi.Forms.CongVan
{
    partial class BaoCaoDinhKy
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
            this.bAO_CAO_DINH_KYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.bAO_CAO_DINH_KYGridControl = new DevExpress.XtraGrid.GridControl();
            this.grvBaoCaoDinhKy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDonViNhanBaoCao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.donViNhanBaoCaoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.bAO_CAO_DINH_KYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAO_CAO_DINH_KYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoDinhKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
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
            this.splitterControl1.Size = new System.Drawing.Size(5, 333);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // bAO_CAO_DINH_KYGridControl
            // 
            this.bAO_CAO_DINH_KYGridControl.DataSource = this.bAO_CAO_DINH_KYBindingSource;
            this.bAO_CAO_DINH_KYGridControl.Location = new System.Drawing.Point(7, 7);
            this.bAO_CAO_DINH_KYGridControl.MainView = this.grvBaoCaoDinhKy;
            this.bAO_CAO_DINH_KYGridControl.Name = "bAO_CAO_DINH_KYGridControl";
            this.bAO_CAO_DINH_KYGridControl.Size = new System.Drawing.Size(382, 319);
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
            this.grvBaoCaoDinhKy.GroupCount = 1;
            this.grvBaoCaoDinhKy.Name = "grvBaoCaoDinhKy";
            this.grvBaoCaoDinhKy.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDonViNhanBaoCao, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grvBaoCaoDinhKy.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvBaoCaoDinhKy_InitNewRow);
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
            this.colNoiDung.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(396, 333);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.bAO_CAO_DINH_KYGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(386, 323);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.bAO_CAO_DINH_KYGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(396, 333);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
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
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup2.Size = new System.Drawing.Size(454, 333);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.donViNhanBaoCaoTextEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(222, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(222, 40);
            this.layoutControlItem3.Text = "Don Vi Nhan Bao Cao:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 13);
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
            this.layoutControl2.Controls.Add(this.lblTrangThai);
            this.layoutControl2.Controls.Add(this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl);
            this.layoutControl2.Controls.Add(this.soCongVanYeuCauTextEdit);
            this.layoutControl2.Controls.Add(this.noiDungMemoEdit);
            this.layoutControl2.Controls.Add(this.donViNhanBaoCaoTextEdit);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(401, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(454, 333);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Location = new System.Drawing.Point(7, 313);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(44, 13);
            this.lblTrangThai.StyleController = this.layoutControl2;
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Sẵn sàng";
            // 
            // bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl
            // 
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.DataSource = this.nGAY_BAO_CAOBindingSource;
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.Location = new System.Drawing.Point(7, 138);
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.MainView = this.grvNgaybaoCao;
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.Name = "bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl";
            this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl.Size = new System.Drawing.Size(440, 171);
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
            this.grvNgaybaoCao.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvNgaybaoCao_InitNewRow);
            // 
            // colNgay
            // 
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 0;
            // 
            // colThang
            // 
            this.colThang.FieldName = "Thang";
            this.colThang.Name = "colThang";
            this.colThang.Visible = true;
            this.colThang.VisibleIndex = 1;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
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
            this.noiDungMemoEdit.Size = new System.Drawing.Size(440, 55);
            this.noiDungMemoEdit.StyleController = this.layoutControl2;
            this.noiDungMemoEdit.TabIndex = 6;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.noiDungMemoEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(444, 75);
            this.layoutControlItem4.Text = "Noi Dung:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.soCongVanYeuCauTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(222, 40);
            this.layoutControlItem5.Text = "So Cong Van Yeu Cau:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(108, 13);
            // 
            // ngayBaoCaoLayoutControlItem
            // 
            this.ngayBaoCaoLayoutControlItem.Control = this.bAO_CAO_DINH_KY_NGAY_BAO_CAOGridControl;
            this.ngayBaoCaoLayoutControlItem.Enabled = false;
            this.ngayBaoCaoLayoutControlItem.Location = new System.Drawing.Point(0, 115);
            this.ngayBaoCaoLayoutControlItem.Name = "ngayBaoCaoLayoutControlItem";
            this.ngayBaoCaoLayoutControlItem.Size = new System.Drawing.Size(444, 191);
            this.ngayBaoCaoLayoutControlItem.Text = "Thời gian báo cáo";
            this.ngayBaoCaoLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.ngayBaoCaoLayoutControlItem.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lblTrangThai;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 306);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(444, 17);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // BaoCaoDinhKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 333);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "BaoCaoDinhKy";
            this.Text = "Báo cáo định kỳ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaoCaoDinhKy_FormClosing);
            this.Load += new System.EventHandler(this.BaoCaoDinhKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bAO_CAO_DINH_KYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAO_CAO_DINH_KYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoDinhKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
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
    }
}