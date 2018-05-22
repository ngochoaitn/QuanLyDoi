namespace QuanLyDoi.Forms.TimKiem
{
    partial class frmTimKiemFileWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemFileWord));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnChonThuMuc = new DevExpress.XtraEditors.SimpleButton();
            this.txtThuMuc = new DevExpress.XtraEditors.TextEdit();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.fileInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvFileInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirectoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirectory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsReadOnly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExists = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationTimeUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastAccessTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastAccessTimeUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastWriteTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastWriteTimeUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttributes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTuKhoa = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThuMuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFileInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnChonThuMuc);
            this.layoutControl1.Controls.Add(this.txtThuMuc);
            this.layoutControl1.Controls.Add(this.btnTimKiem);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtTuKhoa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(659, 347);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnChonThuMuc
            // 
            this.btnChonThuMuc.Location = new System.Drawing.Point(589, 12);
            this.btnChonThuMuc.Name = "btnChonThuMuc";
            this.btnChonThuMuc.Size = new System.Drawing.Size(58, 22);
            this.btnChonThuMuc.StyleController = this.layoutControl1;
            this.btnChonThuMuc.TabIndex = 8;
            this.btnChonThuMuc.Text = "...";
            this.btnChonThuMuc.Click += new System.EventHandler(this.btnChonThuMuc_Click);
            // 
            // txtThuMuc
            // 
            this.txtThuMuc.EditValue = "D:\\NGUYỄN DIỆU THOA";
            this.txtThuMuc.Location = new System.Drawing.Point(56, 12);
            this.txtThuMuc.Name = "txtThuMuc";
            this.txtThuMuc.Size = new System.Drawing.Size(529, 20);
            this.txtThuMuc.StyleController = this.layoutControl1;
            this.txtThuMuc.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(589, 38);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(58, 22);
            this.btnTimKiem.StyleController = this.layoutControl1;
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.fileInfoBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 64);
            this.gridControl1.MainView = this.grvFileInfo;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(635, 271);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvFileInfo});
            // 
            // fileInfoBindingSource
            // 
            this.fileInfoBindingSource.DataSource = typeof(System.IO.FileInfo);
            // 
            // grvFileInfo
            // 
            this.grvFileInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colLength,
            this.colDirectoryName,
            this.colDirectory,
            this.colIsReadOnly,
            this.colExists,
            this.colFullName,
            this.colExtension,
            this.colCreationTime,
            this.colCreationTimeUtc,
            this.colLastAccessTime,
            this.colLastAccessTimeUtc,
            this.colLastWriteTime,
            this.colLastWriteTimeUtc,
            this.colAttributes});
            this.grvFileInfo.GridControl = this.gridControl1;
            this.grvFileInfo.Name = "grvFileInfo";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colLength
            // 
            this.colLength.FieldName = "Length";
            this.colLength.Name = "colLength";
            this.colLength.OptionsColumn.ReadOnly = true;
            // 
            // colDirectoryName
            // 
            this.colDirectoryName.FieldName = "DirectoryName";
            this.colDirectoryName.Name = "colDirectoryName";
            this.colDirectoryName.OptionsColumn.ReadOnly = true;
            this.colDirectoryName.Visible = true;
            this.colDirectoryName.VisibleIndex = 1;
            // 
            // colDirectory
            // 
            this.colDirectory.FieldName = "Directory";
            this.colDirectory.Name = "colDirectory";
            this.colDirectory.OptionsColumn.ReadOnly = true;
            // 
            // colIsReadOnly
            // 
            this.colIsReadOnly.FieldName = "IsReadOnly";
            this.colIsReadOnly.Name = "colIsReadOnly";
            // 
            // colExists
            // 
            this.colExists.FieldName = "Exists";
            this.colExists.Name = "colExists";
            this.colExists.OptionsColumn.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.ReadOnly = true;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 2;
            // 
            // colExtension
            // 
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            this.colExtension.OptionsColumn.ReadOnly = true;
            this.colExtension.Visible = true;
            this.colExtension.VisibleIndex = 3;
            // 
            // colCreationTime
            // 
            this.colCreationTime.FieldName = "CreationTime";
            this.colCreationTime.Name = "colCreationTime";
            this.colCreationTime.Visible = true;
            this.colCreationTime.VisibleIndex = 4;
            // 
            // colCreationTimeUtc
            // 
            this.colCreationTimeUtc.FieldName = "CreationTimeUtc";
            this.colCreationTimeUtc.Name = "colCreationTimeUtc";
            // 
            // colLastAccessTime
            // 
            this.colLastAccessTime.FieldName = "LastAccessTime";
            this.colLastAccessTime.Name = "colLastAccessTime";
            this.colLastAccessTime.Visible = true;
            this.colLastAccessTime.VisibleIndex = 5;
            // 
            // colLastAccessTimeUtc
            // 
            this.colLastAccessTimeUtc.FieldName = "LastAccessTimeUtc";
            this.colLastAccessTimeUtc.Name = "colLastAccessTimeUtc";
            // 
            // colLastWriteTime
            // 
            this.colLastWriteTime.FieldName = "LastWriteTime";
            this.colLastWriteTime.Name = "colLastWriteTime";
            this.colLastWriteTime.Visible = true;
            this.colLastWriteTime.VisibleIndex = 6;
            // 
            // colLastWriteTimeUtc
            // 
            this.colLastWriteTimeUtc.FieldName = "LastWriteTimeUtc";
            this.colLastWriteTimeUtc.Name = "colLastWriteTimeUtc";
            // 
            // colAttributes
            // 
            this.colAttributes.FieldName = "Attributes";
            this.colAttributes.Name = "colAttributes";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.EditValue = "văn nghệ, thể dục ";
            this.txtTuKhoa.Location = new System.Drawing.Point(56, 38);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(529, 20);
            this.txtTuKhoa.StyleController = this.layoutControl1;
            this.txtTuKhoa.TabIndex = 4;
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
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(659, 347);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTuKhoa;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(577, 26);
            this.layoutControlItem1.Text = "Từ khóa";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(639, 275);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnTimKiem;
            this.layoutControlItem3.Location = new System.Drawing.Point(577, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(62, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtThuMuc;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(577, 26);
            this.layoutControlItem4.Text = "Thư mục";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(41, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnChonThuMuc;
            this.layoutControlItem5.Location = new System.Drawing.Point(577, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(62, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmTimKiemFileWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 347);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmTimKiemFileWord";
            this.Text = "frmTimKiemFileWord";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtThuMuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFileInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtTuKhoa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource fileInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvFileInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colDirectoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colDirectory;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colExists;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationTimeUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colLastAccessTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLastAccessTimeUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colLastWriteTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLastWriteTimeUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colAttributes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtThuMuc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnChonThuMuc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}