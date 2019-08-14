namespace QuanLyDoi.Forms.TrucTuan
{
    partial class FormDanhSachCanBoTrucTuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhSachCanBoTrucTuan));
            this.cAN_BOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAN_BOGridControl = new DevExpress.XtraGrid.GridControl();
            this.grvCanBo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHoVaTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCapBac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.cAN_BOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAN_BOGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCanBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // cAN_BOBindingSource
            // 
            this.cAN_BOBindingSource.DataSource = typeof(QuanLyDoi.Database.CAN_BO);
            // 
            // cAN_BOGridControl
            // 
            this.cAN_BOGridControl.DataSource = this.cAN_BOBindingSource;
            this.cAN_BOGridControl.Location = new System.Drawing.Point(12, 12);
            this.cAN_BOGridControl.MainView = this.grvCanBo;
            this.cAN_BOGridControl.Name = "cAN_BOGridControl";
            this.cAN_BOGridControl.Size = new System.Drawing.Size(353, 324);
            this.cAN_BOGridControl.TabIndex = 1;
            this.cAN_BOGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCanBo});
            // 
            // grvCanBo
            // 
            this.grvCanBo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHoVaTen,
            this.colIdCapBac,
            this.colIdChucVu});
            this.grvCanBo.GridControl = this.cAN_BOGridControl;
            this.grvCanBo.Name = "grvCanBo";
            this.grvCanBo.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.grvCanBo.OptionsSelection.MultiSelect = true;
            this.grvCanBo.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colHoVaTen
            // 
            this.colHoVaTen.Caption = "Họ và tên";
            this.colHoVaTen.FieldName = "HoVaTen";
            this.colHoVaTen.Name = "colHoVaTen";
            this.colHoVaTen.Visible = true;
            this.colHoVaTen.VisibleIndex = 1;
            // 
            // colIdCapBac
            // 
            this.colIdCapBac.Caption = "Cấp bậc";
            this.colIdCapBac.FieldName = "MA_CAP_BAC.ND";
            this.colIdCapBac.Name = "colIdCapBac";
            this.colIdCapBac.Visible = true;
            this.colIdCapBac.VisibleIndex = 2;
            // 
            // colIdChucVu
            // 
            this.colIdChucVu.Caption = "Chức vụ";
            this.colIdChucVu.FieldName = "MA_CHUC_VU.ND";
            this.colIdChucVu.Name = "colIdChucVu";
            this.colIdChucVu.Visible = true;
            this.colIdChucVu.VisibleIndex = 3;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.Appearance.Options.UseFont = true;
            this.btnXacNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.ImageOptions.Image")));
            this.btnXacNhan.Location = new System.Drawing.Point(12, 340);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(97, 22);
            this.btnXacNhan.StyleController = this.layoutControl1;
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnXacNhan);
            this.layoutControl1.Controls.Add(this.cAN_BOGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(607, 148, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(377, 374);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(377, 374);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cAN_BOGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(357, 328);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnXacNhan;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 328);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(101, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(178, 328);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(179, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormDanhSachCanBoTrucTuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 374);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormDanhSachCanBoTrucTuan";
            this.Text = "FormDanhSachCanBoTrucTuan";
            this.Load += new System.EventHandler(this.FormDanhSachCanBoTrucTuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cAN_BOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAN_BOGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCanBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cAN_BOBindingSource;
        private DevExpress.XtraGrid.GridControl cAN_BOGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCanBo;
        private DevExpress.XtraGrid.Columns.GridColumn colHoVaTen;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCapBac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdChucVu;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}