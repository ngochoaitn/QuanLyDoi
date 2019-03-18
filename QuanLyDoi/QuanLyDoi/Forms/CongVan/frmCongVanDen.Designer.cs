namespace QuanLyDoi.Forms.CongVan
{
    partial class frmCongVanDen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongVanDen));
            this.cONG_VANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONG_VANGridControl = new DevExpress.XtraGrid.GridControl();
            this.grvCongVan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLoaiCongVan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_IdLoaiCongVan = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.mALOAICONGVANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoKyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiGui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCongVan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrichYeu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbbNam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colND = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cONG_VANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONG_VANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCongVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_IdLoaiCongVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOAICONGVANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // cONG_VANBindingSource
            // 
            this.cONG_VANBindingSource.DataSource = typeof(QuanLyDoi.Database.CONG_VAN);
            // 
            // cONG_VANGridControl
            // 
            this.cONG_VANGridControl.DataSource = this.cONG_VANBindingSource;
            this.cONG_VANGridControl.Location = new System.Drawing.Point(12, 36);
            this.cONG_VANGridControl.MainView = this.grvCongVan;
            this.cONG_VANGridControl.Name = "cONG_VANGridControl";
            this.cONG_VANGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_IdLoaiCongVan});
            this.cONG_VANGridControl.Size = new System.Drawing.Size(721, 283);
            this.cONG_VANGridControl.TabIndex = 1;
            this.cONG_VANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCongVan});
            // 
            // grvCongVan
            // 
            this.grvCongVan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLoaiCongVan,
            this.colNgayNhan,
            this.colSoKyHieu,
            this.colNoiGui,
            this.colNgayCongVan,
            this.colTrichYeu,
            this.colGhiChu});
            this.grvCongVan.GridControl = this.cONG_VANGridControl;
            this.grvCongVan.Name = "grvCongVan";
            this.grvCongVan.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNgayNhan, DevExpress.Data.ColumnSortOrder.Descending)});
            this.grvCongVan.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvCongVan_InitNewRow);
            // 
            // colIdLoaiCongVan
            // 
            this.colIdLoaiCongVan.Caption = "Loại VB";
            this.colIdLoaiCongVan.ColumnEdit = this.rep_IdLoaiCongVan;
            this.colIdLoaiCongVan.FieldName = "IdLoaiCongVan";
            this.colIdLoaiCongVan.MaxWidth = 85;
            this.colIdLoaiCongVan.MinWidth = 70;
            this.colIdLoaiCongVan.Name = "colIdLoaiCongVan";
            this.colIdLoaiCongVan.Visible = true;
            this.colIdLoaiCongVan.VisibleIndex = 0;
            this.colIdLoaiCongVan.Width = 70;
            // 
            // rep_IdLoaiCongVan
            // 
            this.rep_IdLoaiCongVan.AutoHeight = false;
            this.rep_IdLoaiCongVan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rep_IdLoaiCongVan.DataSource = this.mALOAICONGVANBindingSource;
            this.rep_IdLoaiCongVan.DisplayMember = "ND";
            this.rep_IdLoaiCongVan.Name = "rep_IdLoaiCongVan";
            this.rep_IdLoaiCongVan.NullText = "";
            this.rep_IdLoaiCongVan.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.rep_IdLoaiCongVan.ValueMember = "ID";
            // 
            // mALOAICONGVANBindingSource
            // 
            this.mALOAICONGVANBindingSource.DataSource = typeof(QuanLyDoi.Database.MA_LOAI_CONG_VAN);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colND});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colNgayNhan
            // 
            this.colNgayNhan.Caption = "Ngày nhận";
            this.colNgayNhan.FieldName = "NgayNhan";
            this.colNgayNhan.MaxWidth = 85;
            this.colNgayNhan.MinWidth = 80;
            this.colNgayNhan.Name = "colNgayNhan";
            this.colNgayNhan.Visible = true;
            this.colNgayNhan.VisibleIndex = 1;
            this.colNgayNhan.Width = 85;
            // 
            // colSoKyHieu
            // 
            this.colSoKyHieu.Caption = "Số, ký hiệu";
            this.colSoKyHieu.FieldName = "SoKyHieu";
            this.colSoKyHieu.MaxWidth = 100;
            this.colSoKyHieu.MinWidth = 65;
            this.colSoKyHieu.Name = "colSoKyHieu";
            this.colSoKyHieu.Visible = true;
            this.colSoKyHieu.VisibleIndex = 2;
            this.colSoKyHieu.Width = 99;
            // 
            // colNoiGui
            // 
            this.colNoiGui.Caption = "Nơi gửi";
            this.colNoiGui.FieldName = "NoiGui";
            this.colNoiGui.Name = "colNoiGui";
            this.colNoiGui.Visible = true;
            this.colNoiGui.VisibleIndex = 3;
            this.colNoiGui.Width = 99;
            // 
            // colNgayCongVan
            // 
            this.colNgayCongVan.Caption = "Ngày VB";
            this.colNgayCongVan.FieldName = "NgayCongVan";
            this.colNgayCongVan.MaxWidth = 85;
            this.colNgayCongVan.MinWidth = 80;
            this.colNgayCongVan.Name = "colNgayCongVan";
            this.colNgayCongVan.Visible = true;
            this.colNgayCongVan.VisibleIndex = 4;
            this.colNgayCongVan.Width = 85;
            // 
            // colTrichYeu
            // 
            this.colTrichYeu.Caption = "Trích yếu";
            this.colTrichYeu.FieldName = "TrichYeu";
            this.colTrichYeu.Name = "colTrichYeu";
            this.colTrichYeu.Visible = true;
            this.colTrichYeu.VisibleIndex = 5;
            this.colTrichYeu.Width = 99;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MaxWidth = 120;
            this.colGhiChu.MinWidth = 55;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 6;
            this.colGhiChu.Width = 116;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbNam);
            this.layoutControl1.Controls.Add(this.cONG_VANGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(621, 84, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(745, 331);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbNam
            // 
            this.cbbNam.Location = new System.Drawing.Point(36, 12);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbNam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbNam.Size = new System.Drawing.Size(140, 20);
            this.cbbNam.StyleController = this.layoutControl1;
            this.cbbNam.TabIndex = 4;
            this.cbbNam.SelectedIndexChanged += new System.EventHandler(this.cbbNam_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(745, 331);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cONG_VANGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(725, 287);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbbNam;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(168, 24);
            this.layoutControlItem2.Text = "Năm";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(21, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(168, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(557, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colND
            // 
            this.colND.Caption = "Loại VB";
            this.colND.FieldName = "ND";
            this.colND.Name = "colND";
            this.colND.Visible = true;
            this.colND.VisibleIndex = 0;
            // 
            // frmCongVanDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 331);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCongVanDen";
            this.Text = "Quản lý công văn đến";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCongVanDen_FormClosing);
            this.Load += new System.EventHandler(this.frmCongVanDen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cONG_VANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONG_VANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCongVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_IdLoaiCongVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOAICONGVANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cONG_VANBindingSource;
        private DevExpress.XtraGrid.GridControl cONG_VANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCongVan;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoaiCongVan;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit rep_IdLoaiCongVan;
        private System.Windows.Forms.BindingSource mALOAICONGVANBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoKyHieu;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiGui;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCongVan;
        private DevExpress.XtraGrid.Columns.GridColumn colTrichYeu;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbbNam;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colND;
    }
}