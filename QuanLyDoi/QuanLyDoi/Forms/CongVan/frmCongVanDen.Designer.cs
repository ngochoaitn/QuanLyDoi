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
            ((System.ComponentModel.ISupportInitialize)(this.cONG_VANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONG_VANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCongVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_IdLoaiCongVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOAICONGVANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cONG_VANBindingSource
            // 
            this.cONG_VANBindingSource.DataSource = typeof(QuanLyDoi.Database.CONG_VAN);
            // 
            // cONG_VANGridControl
            // 
            this.cONG_VANGridControl.DataSource = this.cONG_VANBindingSource;
            this.cONG_VANGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cONG_VANGridControl.Location = new System.Drawing.Point(0, 0);
            this.cONG_VANGridControl.MainView = this.grvCongVan;
            this.cONG_VANGridControl.Name = "cONG_VANGridControl";
            this.cONG_VANGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_IdLoaiCongVan});
            this.cONG_VANGridControl.Size = new System.Drawing.Size(745, 331);
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
            // 
            // colIdLoaiCongVan
            // 
            this.colIdLoaiCongVan.Caption = "Loại VB";
            this.colIdLoaiCongVan.ColumnEdit = this.rep_IdLoaiCongVan;
            this.colIdLoaiCongVan.FieldName = "IdLoaiCongVan";
            this.colIdLoaiCongVan.MaxWidth = 55;
            this.colIdLoaiCongVan.MinWidth = 45;
            this.colIdLoaiCongVan.Name = "colIdLoaiCongVan";
            this.colIdLoaiCongVan.Visible = true;
            this.colIdLoaiCongVan.VisibleIndex = 0;
            this.colIdLoaiCongVan.Width = 55;
            // 
            // rep_IdLoaiCongVan
            // 
            this.rep_IdLoaiCongVan.AutoHeight = false;
            this.rep_IdLoaiCongVan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rep_IdLoaiCongVan.DataSource = this.mALOAICONGVANBindingSource;
            this.rep_IdLoaiCongVan.Name = "rep_IdLoaiCongVan";
            this.rep_IdLoaiCongVan.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // mALOAICONGVANBindingSource
            // 
            this.mALOAICONGVANBindingSource.DataSource = typeof(QuanLyDoi.Database.MA_LOAI_CONG_VAN);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
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
            // frmCongVanDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 331);
            this.Controls.Add(this.cONG_VANGridControl);
            this.Name = "frmCongVanDen";
            this.Text = "Quản lý công văn đến";
            ((System.ComponentModel.ISupportInitialize)(this.cONG_VANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONG_VANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCongVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_IdLoaiCongVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOAICONGVANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
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
    }
}