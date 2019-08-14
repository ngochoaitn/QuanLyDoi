namespace QuanLyDoi.Forms.LichTrinh
{
    partial class FormLichTrinhCongTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLichTrinhCongTac));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnTaiDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.dateDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.dateTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.lICH_CONG_TACGridControl = new DevExpress.XtraGrid.GridControl();
            this.lICH_CONG_TACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvLichTrinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_colNoiDung = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colDenNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICH_CONG_TACGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICH_CONG_TACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichTrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colNoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnTaiDuLieu);
            this.layoutControl1.Controls.Add(this.dateDenNgay);
            this.layoutControl1.Controls.Add(this.dateTuNgay);
            this.layoutControl1.Controls.Add(this.lICH_CONG_TACGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(393, 277, 375, 239);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(627, 383);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnTaiDuLieu
            // 
            this.btnTaiDuLieu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTaiDuLieu.Appearance.Options.UseFont = true;
            this.btnTaiDuLieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiDuLieu.ImageOptions.Image")));
            this.btnTaiDuLieu.Location = new System.Drawing.Point(332, 12);
            this.btnTaiDuLieu.Name = "btnTaiDuLieu";
            this.btnTaiDuLieu.Size = new System.Drawing.Size(115, 22);
            this.btnTaiDuLieu.StyleController = this.layoutControl1;
            this.btnTaiDuLieu.TabIndex = 7;
            this.btnTaiDuLieu.Text = "Xem lịch trình";
            this.btnTaiDuLieu.Click += new System.EventHandler(this.btnTaiDuLieu_Click);
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.EditValue = null;
            this.dateDenNgay.Location = new System.Drawing.Point(229, 12);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDenNgay.Size = new System.Drawing.Size(99, 20);
            this.dateDenNgay.StyleController = this.layoutControl1;
            this.dateDenNgay.TabIndex = 6;
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.EditValue = null;
            this.dateTuNgay.Location = new System.Drawing.Point(62, 12);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTuNgay.Size = new System.Drawing.Size(113, 20);
            this.dateTuNgay.StyleController = this.layoutControl1;
            this.dateTuNgay.TabIndex = 5;
            // 
            // lICH_CONG_TACGridControl
            // 
            this.lICH_CONG_TACGridControl.DataSource = this.lICH_CONG_TACBindingSource;
            this.lICH_CONG_TACGridControl.Location = new System.Drawing.Point(12, 38);
            this.lICH_CONG_TACGridControl.MainView = this.grvLichTrinh;
            this.lICH_CONG_TACGridControl.Name = "lICH_CONG_TACGridControl";
            this.lICH_CONG_TACGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_colNoiDung});
            this.lICH_CONG_TACGridControl.Size = new System.Drawing.Size(603, 333);
            this.lICH_CONG_TACGridControl.TabIndex = 4;
            this.lICH_CONG_TACGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLichTrinh});
            // 
            // lICH_CONG_TACBindingSource
            // 
            this.lICH_CONG_TACBindingSource.DataSource = typeof(QuanLyDoi.Database.LICH_CONG_TAC);
            // 
            // grvLichTrinh
            // 
            this.grvLichTrinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colThoiGian,
            this.colDenNgay,
            this.colDiaDiem,
            this.colThanhPhan,
            this.colNoiDung});
            this.grvLichTrinh.GridControl = this.lICH_CONG_TACGridControl;
            this.grvLichTrinh.Name = "grvLichTrinh";
            this.grvLichTrinh.OptionsView.RowAutoHeight = true;
            this.grvLichTrinh.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvLichTrinh_InitNewRow);
            // 
            // colThoiGian
            // 
            this.colThoiGian.Caption = "Từ ngày";
            this.colThoiGian.FieldName = "ThoiGian";
            this.colThoiGian.MaxWidth = 95;
            this.colThoiGian.MinWidth = 90;
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Visible = true;
            this.colThoiGian.VisibleIndex = 0;
            this.colThoiGian.Width = 90;
            // 
            // colDiaDiem
            // 
            this.colDiaDiem.Caption = "Địa điểm";
            this.colDiaDiem.FieldName = "DiaDiem";
            this.colDiaDiem.Name = "colDiaDiem";
            this.colDiaDiem.Visible = true;
            this.colDiaDiem.VisibleIndex = 2;
            // 
            // colThanhPhan
            // 
            this.colThanhPhan.Caption = "Thành phần";
            this.colThanhPhan.FieldName = "ThanhPhan";
            this.colThanhPhan.Name = "colThanhPhan";
            this.colThanhPhan.Visible = true;
            this.colThanhPhan.VisibleIndex = 3;
            // 
            // colNoiDung
            // 
            this.colNoiDung.Caption = "Nội dung";
            this.colNoiDung.ColumnEdit = this.rep_colNoiDung;
            this.colNoiDung.FieldName = "NoiDung";
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.Visible = true;
            this.colNoiDung.VisibleIndex = 4;
            // 
            // rep_colNoiDung
            // 
            this.rep_colNoiDung.Name = "rep_colNoiDung";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(627, 383);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lICH_CONG_TACGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(607, 337);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateTuNgay;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(167, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(167, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(167, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Từ ngày";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(47, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateDenNgay;
            this.layoutControlItem3.Location = new System.Drawing.Point(167, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(153, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(153, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(153, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Đến ngày";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(47, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnTaiDuLieu;
            this.layoutControlItem4.Location = new System.Drawing.Point(320, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(119, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(119, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(119, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(439, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(168, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colDenNgay
            // 
            this.colDenNgay.Caption = "Đến ngày";
            this.colDenNgay.FieldName = "DenNgay";
            this.colDenNgay.MaxWidth = 95;
            this.colDenNgay.MinWidth = 90;
            this.colDenNgay.Name = "colDenNgay";
            this.colDenNgay.Visible = true;
            this.colDenNgay.VisibleIndex = 1;
            this.colDenNgay.Width = 90;
            // 
            // FormLichTrinhCongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 383);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormLichTrinhCongTac";
            this.Text = "FormLichTrinhCongTac";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLichTrinhCongTac_FormClosing);
            this.Load += new System.EventHandler(this.FormLichTrinhCongTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICH_CONG_TACGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICH_CONG_TACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLichTrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colNoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl lICH_CONG_TACGridControl;
        private System.Windows.Forms.BindingSource lICH_CONG_TACBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLichTrinh;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhPhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit rep_colNoiDung;
        private DevExpress.XtraEditors.SimpleButton btnTaiDuLieu;
        private DevExpress.XtraEditors.DateEdit dateDenNgay;
        private DevExpress.XtraEditors.DateEdit dateTuNgay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colDenNgay;
    }
}