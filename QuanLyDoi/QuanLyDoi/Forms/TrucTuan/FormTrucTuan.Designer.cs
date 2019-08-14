namespace QuanLyDoi.Forms.TrucTuan
{
    partial class FormTrucTuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrucTuan));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnQuanLyCanBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemTuanMoi = new DevExpress.XtraEditors.SimpleButton();
            this.tRUC_TUAN_CAN_BOGridControl = new DevExpress.XtraGrid.GridControl();
            this.tRUC_TUAN_CAN_BOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvCanBoTrucTuan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tRUC_TUANGridControl = new DevExpress.XtraGrid.GridControl();
            this.tRUC_TUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvTrucTuan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTuNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUAN_CAN_BOGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUAN_CAN_BOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCanBoTrucTuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTrucTuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnQuanLyCanBo);
            this.layoutControl1.Controls.Add(this.btnThemTuanMoi);
            this.layoutControl1.Controls.Add(this.tRUC_TUAN_CAN_BOGridControl);
            this.layoutControl1.Controls.Add(this.tRUC_TUANGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(434, 237, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(597, 368);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnQuanLyCanBo
            // 
            this.btnQuanLyCanBo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyCanBo.Appearance.Options.UseFont = true;
            this.btnQuanLyCanBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyCanBo.ImageOptions.Image")));
            this.btnQuanLyCanBo.Location = new System.Drawing.Point(247, 334);
            this.btnQuanLyCanBo.Name = "btnQuanLyCanBo";
            this.btnQuanLyCanBo.Size = new System.Drawing.Size(167, 22);
            this.btnQuanLyCanBo.StyleController = this.layoutControl1;
            this.btnQuanLyCanBo.TabIndex = 7;
            this.btnQuanLyCanBo.Text = "Danh sách cán bộ trực";
            this.btnQuanLyCanBo.Click += new System.EventHandler(this.btnQuanLyCanBo_Click);
            // 
            // btnThemTuanMoi
            // 
            this.btnThemTuanMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThemTuanMoi.Appearance.Options.UseFont = true;
            this.btnThemTuanMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTuanMoi.ImageOptions.Image")));
            this.btnThemTuanMoi.Location = new System.Drawing.Point(12, 334);
            this.btnThemTuanMoi.Name = "btnThemTuanMoi";
            this.btnThemTuanMoi.Size = new System.Drawing.Size(113, 22);
            this.btnThemTuanMoi.StyleController = this.layoutControl1;
            this.btnThemTuanMoi.TabIndex = 6;
            this.btnThemTuanMoi.Text = "Thêm tuần";
            this.btnThemTuanMoi.Click += new System.EventHandler(this.btnThemTuanMoi_Click);
            // 
            // tRUC_TUAN_CAN_BOGridControl
            // 
            this.tRUC_TUAN_CAN_BOGridControl.DataSource = this.tRUC_TUAN_CAN_BOBindingSource;
            this.tRUC_TUAN_CAN_BOGridControl.Location = new System.Drawing.Point(247, 12);
            this.tRUC_TUAN_CAN_BOGridControl.MainView = this.grvCanBoTrucTuan;
            this.tRUC_TUAN_CAN_BOGridControl.Name = "tRUC_TUAN_CAN_BOGridControl";
            this.tRUC_TUAN_CAN_BOGridControl.Size = new System.Drawing.Size(338, 318);
            this.tRUC_TUAN_CAN_BOGridControl.TabIndex = 5;
            this.tRUC_TUAN_CAN_BOGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCanBoTrucTuan});
            // 
            // tRUC_TUAN_CAN_BOBindingSource
            // 
            this.tRUC_TUAN_CAN_BOBindingSource.DataSource = typeof(QuanLyDoi.Database.TRUC_TUAN_CAN_BO);
            // 
            // grvCanBoTrucTuan
            // 
            this.grvCanBoTrucTuan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHoTen,
            this.colSoDienThoai,
            this.colGhiChu});
            this.grvCanBoTrucTuan.GridControl = this.tRUC_TUAN_CAN_BOGridControl;
            this.grvCanBoTrucTuan.Name = "grvCanBoTrucTuan";
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ và tên";
            this.colHoTen.FieldName = "CAN_BO.HoVaTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 0;
            this.colHoTen.Width = 140;
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.Caption = "Số điện thoại";
            this.colSoDienThoai.FieldName = "CAN_BO.SoDienThoai";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.Visible = true;
            this.colSoDienThoai.VisibleIndex = 1;
            this.colSoDienThoai.Width = 180;
            // 
            // tRUC_TUANGridControl
            // 
            this.tRUC_TUANGridControl.DataSource = this.tRUC_TUANBindingSource;
            this.tRUC_TUANGridControl.Location = new System.Drawing.Point(12, 12);
            this.tRUC_TUANGridControl.MainView = this.grvTrucTuan;
            this.tRUC_TUANGridControl.Name = "tRUC_TUANGridControl";
            this.tRUC_TUANGridControl.Size = new System.Drawing.Size(226, 318);
            this.tRUC_TUANGridControl.TabIndex = 4;
            this.tRUC_TUANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTrucTuan});
            // 
            // tRUC_TUANBindingSource
            // 
            this.tRUC_TUANBindingSource.DataSource = typeof(QuanLyDoi.Database.TRUC_TUAN);
            this.tRUC_TUANBindingSource.CurrentChanged += new System.EventHandler(this.tRUC_TUANBindingSource_CurrentChanged);
            // 
            // grvTrucTuan
            // 
            this.grvTrucTuan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTuNgay,
            this.colDenNgay});
            this.grvTrucTuan.GridControl = this.tRUC_TUANGridControl;
            this.grvTrucTuan.Name = "grvTrucTuan";
            // 
            // colTuNgay
            // 
            this.colTuNgay.Caption = "Từ ngày";
            this.colTuNgay.FieldName = "TuNgay";
            this.colTuNgay.Name = "colTuNgay";
            this.colTuNgay.Visible = true;
            this.colTuNgay.VisibleIndex = 0;
            // 
            // colDenNgay
            // 
            this.colDenNgay.Caption = "Đến ngày";
            this.colDenNgay.FieldName = "DenNgay";
            this.colDenNgay.Name = "colDenNgay";
            this.colDenNgay.Visible = true;
            this.colDenNgay.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(597, 368);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tRUC_TUANGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(230, 322);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tRUC_TUAN_CAN_BOGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(235, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(342, 322);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(230, 0);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(5, 322);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnThemTuanMoi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 322);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(117, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnQuanLyCanBo;
            this.layoutControlItem4.Location = new System.Drawing.Point(235, 322);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(171, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(117, 322);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(118, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(406, 322);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(171, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            // 
            // FormTrucTuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 368);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormTrucTuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trực tuần";
            this.Load += new System.EventHandler(this.FormTrucTuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUAN_CAN_BOGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUAN_CAN_BOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCanBoTrucTuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUC_TUANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTrucTuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource tRUC_TUANBindingSource;
        private DevExpress.XtraGrid.GridControl tRUC_TUAN_CAN_BOGridControl;
        private System.Windows.Forms.BindingSource tRUC_TUAN_CAN_BOBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCanBoTrucTuan;
        private DevExpress.XtraGrid.GridControl tRUC_TUANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTrucTuan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colTuNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colDenNgay;
        private DevExpress.XtraEditors.SimpleButton btnQuanLyCanBo;
        private DevExpress.XtraEditors.SimpleButton btnThemTuanMoi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
    }
}