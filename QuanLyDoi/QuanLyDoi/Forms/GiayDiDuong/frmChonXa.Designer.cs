namespace QuanLyDoi.Forms.GiayDiDuong
{
    partial class frmChonXa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonXa));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnXuatGiay = new DevExpress.XtraEditors.SimpleButton();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.chonDiaBanXaGridControl = new DevExpress.XtraGrid.GridControl();
            this.chonDiaBanXaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bgrvChonXa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colID_CAN_BO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rep_colID_CAN_BO = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.cANBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colID_DIAN_XA_1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colID_DIAN_XA_2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colID_DIAN_XA_3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colID_DIAN_XA_4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colID_DIAN_XA_5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colID_DIAN_XA_6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colID_DIAN_XA_7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colID_DIAN_XA_8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTEN_CAC_XA_DUOC_CHON = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chonDiaBanXaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chonDiaBanXaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgrvChonXa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colID_CAN_BO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnXuatGiay);
            this.layoutControl1.Controls.Add(this.gridSplitContainer1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(563, 167, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(865, 376);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnXuatGiay
            // 
            this.btnXuatGiay.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXuatGiay.Appearance.Options.UseFont = true;
            this.btnXuatGiay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatGiay.ImageOptions.Image")));
            this.btnXuatGiay.Location = new System.Drawing.Point(765, 335);
            this.btnXuatGiay.Name = "btnXuatGiay";
            this.btnXuatGiay.Size = new System.Drawing.Size(97, 38);
            this.btnXuatGiay.StyleController = this.layoutControl1;
            this.btnXuatGiay.TabIndex = 5;
            this.btnXuatGiay.Text = "Xuất giấy";
            this.btnXuatGiay.Click += new System.EventHandler(this.btnXuatGiay_Click);
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.chonDiaBanXaGridControl;
            this.gridSplitContainer1.Location = new System.Drawing.Point(3, 3);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.chonDiaBanXaGridControl);
            this.gridSplitContainer1.Size = new System.Drawing.Size(859, 328);
            this.gridSplitContainer1.TabIndex = 4;
            // 
            // chonDiaBanXaGridControl
            // 
            this.chonDiaBanXaGridControl.DataSource = this.chonDiaBanXaBindingSource;
            this.chonDiaBanXaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chonDiaBanXaGridControl.Location = new System.Drawing.Point(0, 0);
            this.chonDiaBanXaGridControl.MainView = this.bgrvChonXa;
            this.chonDiaBanXaGridControl.Name = "chonDiaBanXaGridControl";
            this.chonDiaBanXaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_colID_CAN_BO});
            this.chonDiaBanXaGridControl.Size = new System.Drawing.Size(859, 328);
            this.chonDiaBanXaGridControl.TabIndex = 0;
            this.chonDiaBanXaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgrvChonXa});
            // 
            // chonDiaBanXaBindingSource
            // 
            this.chonDiaBanXaBindingSource.DataSource = typeof(QuanLyDoi.Forms.GiayDiDuong.ChonDiaBanXa);
            // 
            // bgrvChonXa
            // 
            this.bgrvChonXa.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.bgrvChonXa.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colID_CAN_BO,
            this.colID_DIAN_XA_1,
            this.colID_DIAN_XA_2,
            this.colID_DIAN_XA_3,
            this.colID_DIAN_XA_4,
            this.colID_DIAN_XA_5,
            this.colID_DIAN_XA_6,
            this.colID_DIAN_XA_7,
            this.colID_DIAN_XA_8,
            this.colTEN_CAC_XA_DUOC_CHON});
            this.bgrvChonXa.GridControl = this.chonDiaBanXaGridControl;
            this.bgrvChonXa.Name = "bgrvChonXa";
            this.bgrvChonXa.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.bgrvChonXa_CellValueChanging);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colID_CAN_BO);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 140;
            // 
            // colID_CAN_BO
            // 
            this.colID_CAN_BO.Caption = "Họ tên";
            this.colID_CAN_BO.ColumnEdit = this.rep_colID_CAN_BO;
            this.colID_CAN_BO.FieldName = "ID_CAN_BO";
            this.colID_CAN_BO.MinWidth = 120;
            this.colID_CAN_BO.Name = "colID_CAN_BO";
            this.colID_CAN_BO.OptionsColumn.AllowEdit = false;
            this.colID_CAN_BO.Visible = true;
            this.colID_CAN_BO.Width = 140;
            // 
            // rep_colID_CAN_BO
            // 
            this.rep_colID_CAN_BO.AutoHeight = false;
            this.rep_colID_CAN_BO.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rep_colID_CAN_BO.DataSource = this.cANBOBindingSource;
            this.rep_colID_CAN_BO.DisplayMember = "HoVaTen";
            this.rep_colID_CAN_BO.Name = "rep_colID_CAN_BO";
            this.rep_colID_CAN_BO.NullText = "";
            this.rep_colID_CAN_BO.ValueMember = "IdCanBo";
            this.rep_colID_CAN_BO.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // cANBOBindingSource
            // 
            this.cANBOBindingSource.DataSource = typeof(QuanLyDoi.Database.CAN_BO);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Danh sách xã";
            this.gridBand2.Columns.Add(this.colID_DIAN_XA_1);
            this.gridBand2.Columns.Add(this.colID_DIAN_XA_2);
            this.gridBand2.Columns.Add(this.colID_DIAN_XA_3);
            this.gridBand2.Columns.Add(this.colID_DIAN_XA_4);
            this.gridBand2.Columns.Add(this.colID_DIAN_XA_5);
            this.gridBand2.Columns.Add(this.colID_DIAN_XA_6);
            this.gridBand2.Columns.Add(this.colID_DIAN_XA_7);
            this.gridBand2.Columns.Add(this.colID_DIAN_XA_8);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 80;
            // 
            // colID_DIAN_XA_1
            // 
            this.colID_DIAN_XA_1.FieldName = "CHON_XA_1";
            this.colID_DIAN_XA_1.MinWidth = 80;
            this.colID_DIAN_XA_1.Name = "colID_DIAN_XA_1";
            this.colID_DIAN_XA_1.Width = 80;
            // 
            // colID_DIAN_XA_2
            // 
            this.colID_DIAN_XA_2.FieldName = "CHON_XA_2";
            this.colID_DIAN_XA_2.MinWidth = 80;
            this.colID_DIAN_XA_2.Name = "colID_DIAN_XA_2";
            this.colID_DIAN_XA_2.Width = 80;
            // 
            // colID_DIAN_XA_3
            // 
            this.colID_DIAN_XA_3.FieldName = "CHON_XA_3";
            this.colID_DIAN_XA_3.MinWidth = 80;
            this.colID_DIAN_XA_3.Name = "colID_DIAN_XA_3";
            this.colID_DIAN_XA_3.Width = 80;
            // 
            // colID_DIAN_XA_4
            // 
            this.colID_DIAN_XA_4.FieldName = "CHON_XA_4";
            this.colID_DIAN_XA_4.MinWidth = 80;
            this.colID_DIAN_XA_4.Name = "colID_DIAN_XA_4";
            this.colID_DIAN_XA_4.Width = 80;
            // 
            // colID_DIAN_XA_5
            // 
            this.colID_DIAN_XA_5.FieldName = "CHON_XA_5";
            this.colID_DIAN_XA_5.MinWidth = 80;
            this.colID_DIAN_XA_5.Name = "colID_DIAN_XA_5";
            this.colID_DIAN_XA_5.Width = 80;
            // 
            // colID_DIAN_XA_6
            // 
            this.colID_DIAN_XA_6.FieldName = "CHON_XA_6";
            this.colID_DIAN_XA_6.MinWidth = 80;
            this.colID_DIAN_XA_6.Name = "colID_DIAN_XA_6";
            this.colID_DIAN_XA_6.Width = 80;
            // 
            // colID_DIAN_XA_7
            // 
            this.colID_DIAN_XA_7.FieldName = "CHON_XA_7";
            this.colID_DIAN_XA_7.MinWidth = 80;
            this.colID_DIAN_XA_7.Name = "colID_DIAN_XA_7";
            this.colID_DIAN_XA_7.Width = 80;
            // 
            // colID_DIAN_XA_8
            // 
            this.colID_DIAN_XA_8.FieldName = "CHON_XA_8";
            this.colID_DIAN_XA_8.MinWidth = 80;
            this.colID_DIAN_XA_8.Name = "colID_DIAN_XA_8";
            this.colID_DIAN_XA_8.Width = 80;
            // 
            // gridBand3
            // 
            this.gridBand3.Columns.Add(this.colTEN_CAC_XA_DUOC_CHON);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 200;
            // 
            // colTEN_CAC_XA_DUOC_CHON
            // 
            this.colTEN_CAC_XA_DUOC_CHON.Caption = "Các xã được chọn";
            this.colTEN_CAC_XA_DUOC_CHON.FieldName = "TEN_CAC_XA_DUOC_CHON";
            this.colTEN_CAC_XA_DUOC_CHON.MinWidth = 200;
            this.colTEN_CAC_XA_DUOC_CHON.Name = "colTEN_CAC_XA_DUOC_CHON";
            this.colTEN_CAC_XA_DUOC_CHON.OptionsColumn.AllowEdit = false;
            this.colTEN_CAC_XA_DUOC_CHON.Visible = true;
            this.colTEN_CAC_XA_DUOC_CHON.Width = 200;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlGroup1.Size = new System.Drawing.Size(865, 376);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridSplitContainer1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(863, 332);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnXuatGiay;
            this.layoutControlItem1.Location = new System.Drawing.Point(762, 332);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(101, 42);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(101, 42);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(101, 42);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 332);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(762, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmChonXa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 376);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmChonXa";
            this.Text = "frmChonXa";
            this.Load += new System.EventHandler(this.frmChonXa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chonDiaBanXaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chonDiaBanXaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgrvChonXa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_colID_CAN_BO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cANBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl chonDiaBanXaGridControl;
        private System.Windows.Forms.BindingSource chonDiaBanXaBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgrvChonXa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID_CAN_BO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID_DIAN_XA_1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID_DIAN_XA_2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID_DIAN_XA_3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID_DIAN_XA_4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID_DIAN_XA_5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID_DIAN_XA_6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID_DIAN_XA_7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID_DIAN_XA_8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTEN_CAC_XA_DUOC_CHON;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit rep_colID_CAN_BO;
        private System.Windows.Forms.BindingSource cANBOBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnXuatGiay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}