namespace QuanLyDoi.Forms.HeThong
{
    partial class FormIntro
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.linkRefresh = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.tRUC_TUAN_CAN_BOGridControl = new DevExpress.XtraGrid.GridControl();
            this.tRUC_TUAN_CAN_BOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvTrucTuan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapBac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_colGhiChu = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.lICH_CONG_TACGridControl = new DevExpress.XtraGrid.GridControl();
            this.lICH_CONG_TACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvLichCongTac = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_colNoiDung = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_colThanhPhan = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lgcTrucTuan = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUAN_CAN_BOGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUAN_CAN_BOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTrucTuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colGhiChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICH_CONG_TACGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICH_CONG_TACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichCongTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colNoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colThanhPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgcTrucTuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.linkRefresh);
            this.layoutControl1.Controls.Add(this.tRUC_TUAN_CAN_BOGridControl);
            this.layoutControl1.Controls.Add(this.lICH_CONG_TACGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(748, 585);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // linkRefresh
            // 
            this.linkRefresh.Location = new System.Drawing.Point(12, 560);
            this.linkRefresh.Name = "linkRefresh";
            this.linkRefresh.Size = new System.Drawing.Size(38, 13);
            this.linkRefresh.StyleController = this.layoutControl1;
            this.linkRefresh.TabIndex = 6;
            this.linkRefresh.Text = "Làm mới";
            this.linkRefresh.Click += new System.EventHandler(this.linkRefresh_Click);
            // 
            // tRUC_TUAN_CAN_BOGridControl
            // 
            this.tRUC_TUAN_CAN_BOGridControl.DataSource = this.tRUC_TUAN_CAN_BOBindingSource;
            this.tRUC_TUAN_CAN_BOGridControl.Location = new System.Drawing.Point(24, 321);
            this.tRUC_TUAN_CAN_BOGridControl.MainView = this.grvTrucTuan;
            this.tRUC_TUAN_CAN_BOGridControl.Name = "tRUC_TUAN_CAN_BOGridControl";
            this.tRUC_TUAN_CAN_BOGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_colGhiChu});
            this.tRUC_TUAN_CAN_BOGridControl.Size = new System.Drawing.Size(700, 223);
            this.tRUC_TUAN_CAN_BOGridControl.TabIndex = 5;
            this.tRUC_TUAN_CAN_BOGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTrucTuan});
            // 
            // tRUC_TUAN_CAN_BOBindingSource
            // 
            this.tRUC_TUAN_CAN_BOBindingSource.DataSource = typeof(QuanLyDoi.Database.TRUC_TUAN_CAN_BO);
            // 
            // grvTrucTuan
            // 
            this.grvTrucTuan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHoTen,
            this.colCapBac,
            this.colChucVu,
            this.colSoDienThoai,
            this.colGhiChu});
            this.grvTrucTuan.GridControl = this.tRUC_TUAN_CAN_BOGridControl;
            this.grvTrucTuan.Name = "grvTrucTuan";
            this.grvTrucTuan.OptionsBehavior.Editable = false;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ và tên";
            this.colHoTen.FieldName = "CAN_BO.HoVaTen";
            this.colHoTen.MinWidth = 120;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 0;
            this.colHoTen.Width = 120;
            // 
            // colCapBac
            // 
            this.colCapBac.Caption = "Cấp bậc";
            this.colCapBac.FieldName = "CAN_BO.MA_CAP_BAC.ND";
            this.colCapBac.MaxWidth = 120;
            this.colCapBac.MinWidth = 85;
            this.colCapBac.Name = "colCapBac";
            this.colCapBac.Visible = true;
            this.colCapBac.VisibleIndex = 1;
            this.colCapBac.Width = 85;
            // 
            // colChucVu
            // 
            this.colChucVu.Caption = "Chức vụ";
            this.colChucVu.FieldName = "CAN_BO.MA_CHUC_VU.ND";
            this.colChucVu.MaxWidth = 120;
            this.colChucVu.MinWidth = 85;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 2;
            this.colChucVu.Width = 85;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.Caption = "Số điện thoại";
            this.colSoDienThoai.FieldName = "CAN_BO.SoDienThoai";
            this.colSoDienThoai.MaxWidth = 150;
            this.colSoDienThoai.MinWidth = 110;
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 3;
            this.colSoDienThoai.Width = 110;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.ColumnEdit = this.rep_colGhiChu;
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 4;
            this.colGhiChu.Width = 170;
            // 
            // rep_colGhiChu
            // 
            this.rep_colGhiChu.Name = "rep_colGhiChu";
            // 
            // lICH_CONG_TACGridControl
            // 
            this.lICH_CONG_TACGridControl.DataSource = this.lICH_CONG_TACBindingSource;
            this.lICH_CONG_TACGridControl.Location = new System.Drawing.Point(24, 42);
            this.lICH_CONG_TACGridControl.MainView = this.grvLichCongTac;
            this.lICH_CONG_TACGridControl.Name = "lICH_CONG_TACGridControl";
            this.lICH_CONG_TACGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_colNoiDung,
            this.rep_colThanhPhan});
            this.lICH_CONG_TACGridControl.Size = new System.Drawing.Size(700, 233);
            this.lICH_CONG_TACGridControl.TabIndex = 4;
            this.lICH_CONG_TACGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLichCongTac});
            // 
            // lICH_CONG_TACBindingSource
            // 
            this.lICH_CONG_TACBindingSource.DataSource = typeof(QuanLyDoi.Database.LICH_CONG_TAC);
            // 
            // grvLichCongTac
            // 
            this.grvLichCongTac.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNoiDung,
            this.colThoiGian,
            this.colDiaDiem,
            this.colThanhPhan});
            this.grvLichCongTac.GridControl = this.lICH_CONG_TACGridControl;
            this.grvLichCongTac.Name = "grvLichCongTac";
            this.grvLichCongTac.OptionsBehavior.Editable = false;
            this.grvLichCongTac.OptionsView.RowAutoHeight = true;
            // 
            // colNoiDung
            // 
            this.colNoiDung.Caption = "Nội dung";
            this.colNoiDung.ColumnEdit = this.rep_colNoiDung;
            this.colNoiDung.FieldName = "NoiDung";
            this.colNoiDung.MinWidth = 400;
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.Visible = true;
            this.colNoiDung.VisibleIndex = 0;
            this.colNoiDung.Width = 400;
            // 
            // rep_colNoiDung
            // 
            this.rep_colNoiDung.Name = "rep_colNoiDung";
            // 
            // colThoiGian
            // 
            this.colThoiGian.AppearanceCell.Options.UseTextOptions = true;
            this.colThoiGian.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colThoiGian.Caption = "Thời gian";
            this.colThoiGian.FieldName = "ThoiGian";
            this.colThoiGian.MaxWidth = 80;
            this.colThoiGian.MinWidth = 85;
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Visible = true;
            this.colThoiGian.VisibleIndex = 1;
            this.colThoiGian.Width = 85;
            // 
            // colDiaDiem
            // 
            this.colDiaDiem.Caption = "Địa điểm";
            this.colDiaDiem.FieldName = "DiaDiem";
            this.colDiaDiem.Name = "colDiaDiem";
            this.colDiaDiem.Visible = true;
            this.colDiaDiem.VisibleIndex = 2;
            this.colDiaDiem.Width = 166;
            // 
            // colThanhPhan
            // 
            this.colThanhPhan.Caption = "Thành phần";
            this.colThanhPhan.ColumnEdit = this.rep_colThanhPhan;
            this.colThanhPhan.FieldName = "ThanhPhan";
            this.colThanhPhan.Name = "colThanhPhan";
            this.colThanhPhan.Visible = true;
            this.colThanhPhan.VisibleIndex = 3;
            this.colThanhPhan.Width = 271;
            // 
            // rep_colThanhPhan
            // 
            this.rep_colThanhPhan.Name = "rep_colThanhPhan";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.lgcTrucTuan,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(748, 585);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(728, 279);
            this.layoutControlGroup2.Text = "Công tác trọng tâm 14 ngày tới";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lICH_CONG_TACGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(704, 237);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lgcTrucTuan
            // 
            this.lgcTrucTuan.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.lgcTrucTuan.Location = new System.Drawing.Point(0, 279);
            this.lgcTrucTuan.Name = "lgcTrucTuan";
            this.lgcTrucTuan.Size = new System.Drawing.Size(728, 269);
            this.lgcTrucTuan.Text = "Trực tuần";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tRUC_TUAN_CAN_BOGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(704, 227);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.linkRefresh;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 548);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(728, 17);
            this.layoutControlItem3.Text = "Làm mới";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // FormIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 585);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormIntro";
            this.Text = "FormIntro";
            this.Load += new System.EventHandler(this.FormIntro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUAN_CAN_BOGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUAN_CAN_BOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTrucTuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colGhiChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICH_CONG_TACGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICH_CONG_TACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichCongTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colNoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colThanhPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgcTrucTuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl lICH_CONG_TACGridControl;
        private System.Windows.Forms.BindingSource lICH_CONG_TACBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLichCongTac;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.GridControl tRUC_TUAN_CAN_BOGridControl;
        private System.Windows.Forms.BindingSource tRUC_TUAN_CAN_BOBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTrucTuan;
        private DevExpress.XtraLayout.LayoutControlGroup lgcTrucTuan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhPhan;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colCapBac;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit rep_colNoiDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit rep_colThanhPhan;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit rep_colGhiChu;
    }
}