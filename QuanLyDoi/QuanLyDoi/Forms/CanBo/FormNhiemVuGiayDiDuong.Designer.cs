namespace QuanLyDoi.Forms.CanBo
{
    partial class FormNhiemVuGiayDiDuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhiemVuGiayDiDuong));
            this.cAN_BOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAN_BOGridControl = new DevExpress.XtraGrid.GridControl();
            this.grvCanBo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHoVaTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCapBac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhiemVuGiayDiDuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_colNhiemVuGiayDiDuong = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cAN_BOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAN_BOGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCanBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colNhiemVuGiayDiDuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cAN_BOBindingSource
            // 
            this.cAN_BOBindingSource.DataSource = typeof(QuanLyDoi.Database.CAN_BO);
            // 
            // cAN_BOGridControl
            // 
            this.cAN_BOGridControl.DataSource = this.cAN_BOBindingSource;
            this.cAN_BOGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cAN_BOGridControl.Location = new System.Drawing.Point(0, 0);
            this.cAN_BOGridControl.MainView = this.grvCanBo;
            this.cAN_BOGridControl.Name = "cAN_BOGridControl";
            this.cAN_BOGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_colNhiemVuGiayDiDuong});
            this.cAN_BOGridControl.Size = new System.Drawing.Size(710, 376);
            this.cAN_BOGridControl.TabIndex = 1;
            this.cAN_BOGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCanBo});
            // 
            // grvCanBo
            // 
            this.grvCanBo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHoVaTen,
            this.colIdCapBac,
            this.colIdChucVu,
            this.colNhiemVuGiayDiDuong});
            this.grvCanBo.GridControl = this.cAN_BOGridControl;
            this.grvCanBo.Name = "grvCanBo";
            this.grvCanBo.OptionsView.RowAutoHeight = true;
            // 
            // colHoVaTen
            // 
            this.colHoVaTen.Caption = "Họ và tên";
            this.colHoVaTen.FieldName = "HoVaTen";
            this.colHoVaTen.MinWidth = 120;
            this.colHoVaTen.Name = "colHoVaTen";
            this.colHoVaTen.Visible = true;
            this.colHoVaTen.VisibleIndex = 0;
            this.colHoVaTen.Width = 120;
            // 
            // colIdCapBac
            // 
            this.colIdCapBac.Caption = "Cấp bậc";
            this.colIdCapBac.FieldName = "MA_CAP_BAC.ND";
            this.colIdCapBac.MaxWidth = 75;
            this.colIdCapBac.MinWidth = 70;
            this.colIdCapBac.Name = "colIdCapBac";
            this.colIdCapBac.Visible = true;
            this.colIdCapBac.VisibleIndex = 1;
            // 
            // colIdChucVu
            // 
            this.colIdChucVu.Caption = "Chức vụ";
            this.colIdChucVu.FieldName = "MA_CHUC_VU.ND";
            this.colIdChucVu.MaxWidth = 75;
            this.colIdChucVu.MinWidth = 70;
            this.colIdChucVu.Name = "colIdChucVu";
            this.colIdChucVu.Visible = true;
            this.colIdChucVu.VisibleIndex = 2;
            // 
            // colNhiemVuGiayDiDuong
            // 
            this.colNhiemVuGiayDiDuong.Caption = "Nhiệm vụ";
            this.colNhiemVuGiayDiDuong.ColumnEdit = this.rep_colNhiemVuGiayDiDuong;
            this.colNhiemVuGiayDiDuong.FieldName = "NhiemVuGiayDiDuong";
            this.colNhiemVuGiayDiDuong.MinWidth = 200;
            this.colNhiemVuGiayDiDuong.Name = "colNhiemVuGiayDiDuong";
            this.colNhiemVuGiayDiDuong.Visible = true;
            this.colNhiemVuGiayDiDuong.VisibleIndex = 3;
            this.colNhiemVuGiayDiDuong.Width = 200;
            // 
            // rep_colNhiemVuGiayDiDuong
            // 
            this.rep_colNhiemVuGiayDiDuong.Name = "rep_colNhiemVuGiayDiDuong";
            // 
            // FormNhiemVuGiayDiDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 376);
            this.Controls.Add(this.cAN_BOGridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNhiemVuGiayDiDuong";
            this.Text = "Nhiệm vụ giấy đi đường";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhiemVuGiayDiDuong_FormClosing);
            this.Load += new System.EventHandler(this.FormNhiemVuGiayDiDuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAN_BOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAN_BOGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCanBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colNhiemVuGiayDiDuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cAN_BOBindingSource;
        private DevExpress.XtraGrid.GridControl cAN_BOGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCanBo;
        private DevExpress.XtraGrid.Columns.GridColumn colHoVaTen;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCapBac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colNhiemVuGiayDiDuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit rep_colNhiemVuGiayDiDuong;
    }
}