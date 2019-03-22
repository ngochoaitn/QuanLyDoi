using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoi.Lib
{
    static class CustomizeGridview
    {
        /// <summary>
        /// Đặt các giá trị cho grid view như màu select, odd, focus, no border ...
        /// CustomizeGridview.SetGridViewAppearance(gridView1);
        /// </summary>
        /// <param name="gridView1"></param>
        public static GridView SetGridViewAppearance(this GridView gridView1, bool phanbietmaucachang=true, bool ChieuCaoHang = true, 
            bool HangThemMoi = false, bool HangThemMoiODau = false)
        {
            gridView1.RowHeight = 24;
            gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gridView1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Azure;
            gridView1.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            gridView1.Appearance.FocusedCell.Options.UseBackColor = true;

            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Azure;
            gridView1.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            gridView1.Appearance.FocusedRow.ForeColor = Color.Blue;
            gridView1.Appearance.SelectedRow.Options.UseFont = true;

            if (phanbietmaucachang)
            {
                gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
                gridView1.Appearance.OddRow.Options.UseBackColor = true;
                gridView1.OptionsView.EnableAppearanceOddRow = true;
            }
            else
            {
                gridView1.OptionsView.EnableAppearanceOddRow = false;
            }

            gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Maroon;
            gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            gridView1.Appearance.SelectedRow.Options.UseFont = true;
            gridView1.Appearance.SelectedRow.Options.UseForeColor = true;

            gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridView1.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm...";

            gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;

            if (HangThemMoi)
            {
                gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
                gridView1.NewItemRowText = "Click vào đây để thêm mới...";
                if (HangThemMoiODau)
                    gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                else
                    gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gridView1.Appearance.TopNewRow.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            }

            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            if (ChieuCaoHang)
                gridView1.CalcRowHeight += gridView1_CalcRowHeight;

            gridView1.OptionsPrint.AutoWidth = false;
            return gridView1;
        }

        public static BandedGridView SetGridViewAppearance(this BandedGridView gridView1, bool phanbietmaucachang = true, bool ChieuCaoHang = true)
        {
            gridView1.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            gridView1.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView1.RowHeight = 24;
            gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gridView1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Azure;
            gridView1.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            gridView1.Appearance.FocusedCell.Options.UseBackColor = true;

            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Azure;
            gridView1.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;

            if (phanbietmaucachang)
            {
                gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
                gridView1.Appearance.OddRow.Options.UseBackColor = true;
                gridView1.OptionsView.EnableAppearanceOddRow = true;
            }
            else
            {
                gridView1.OptionsView.EnableAppearanceOddRow = false;
            }

            gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Maroon;
            gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            gridView1.Appearance.SelectedRow.Options.UseFont = true;
            gridView1.Appearance.SelectedRow.Options.UseForeColor = true;

            gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridView1.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm...";

            gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;

            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;

            return gridView1;
        }

        static void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.LayoutChanged();
            }
            catch {  }
        }

        static void gridView1_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0 && e.RowHandle == view.FocusedRowHandle)
                e.RowHeight = 26;
            else
                e.RowHeight = 24;
        }
        /// <summary>
        /// Tùy biến grid bởi Trungpos SD
        /// CustomizeGridview.MyGridLocalizer.Active = new CustomizeGridview.MyGridLocalizer();
        /// </summary>
        public class MyGridLocalizer : GridLocalizer
        {
            public override string GetLocalizedString(GridStringId id)
            {
                if (id == GridStringId.FindControlFindButton)
                    return "Tìm";
                if (id == GridStringId.FindControlClearButton)
                    return "Bỏ";
                if (id == GridStringId.GridGroupPanelText)
                    return "Kéo thả cột vào đây để gom nhóm";
                if (id == GridStringId.MenuColumnSortAscending)
                    return "Sắp xếp tăng dần";
                if (id == GridStringId.MenuColumnSortDescending)
                    return "Sắp xếp giảm dần";
                if (id == GridStringId.MenuColumnClearSorting)
                    return "Bỏ sắp xếp";
                if (id == GridStringId.MenuColumnGroup)
                    return "Gom nhóm theo cột này";
                if (id == GridStringId.MenuGroupPanelShow)
                    return "Hiện hộp gom nhóm";
                if (id == GridStringId.MenuGroupPanelHide)
                    return "Ẩn hộp gom nhóm";
                if (id == GridStringId.MenuGroupPanelFullExpand)
                    return "Mở tất cả các nhóm";
                if (id == GridStringId.MenuGroupPanelFullCollapse)
                    return "Thu tất cả các nhóm";
                if (id == GridStringId.MenuColumnUnGroup)
                    return "Bỏ gom nhóm";
                if (id == GridStringId.MenuColumnRemoveColumn)
                    return "Ẩn cột này";
                if (id == GridStringId.MenuColumnShowColumn)
                    return "Hiện cột này";
                if (id == GridStringId.MenuColumnColumnCustomization)
                    return "Tùy chỉnh cột";
                if (id == GridStringId.CustomizationCaption)
                    return "Tùy chỉnh cột";
                //if (id == GridStringId.CustomizationColumns)
                //    return "Kéo và thả cột vào đây để tùy chỉnh";
                //if (id == GridStringId.CustomizationBands)
                //    return "Kéo và thả cột vào đây để tùy chỉnh";
                //if (id == GridStringId.CustomizationFormBandHint)
                //    return "Kéo và thả cột vào đây để tùy chỉnh";
                if (id == GridStringId.CustomizationFormColumnHint)
                    return "Kéo và thả cột vào đây để tùy chỉnh";
                if (id == GridStringId.MenuColumnBestFit)
                    return "Căn chỉnh";
                if (id == GridStringId.MenuColumnBestFitAllColumns)
                    return "Căn chỉnh tất cả";
                if (id == GridStringId.MenuColumnFilterEditor)
                    return "Cài đặt lọc";
                //if (id == GridStringId.MenuColumnFilter)
                //    return "menu filter";
                if (id == GridStringId.PopupFilterCustom)
                    return "(Tùy chọn)";
                if (id == GridStringId.PopupFilterAll)
                    return "(Tất cả)";
                if (id == GridStringId.FilterPanelCustomizeButton)
                    return "Sửa lọc";
                if (id == GridStringId.FilterBuilderCaption)
                    return "Cài đặt lọc";
                if (id == GridStringId.FilterBuilderOkButton)
                    return "Đồng ý";
                if (id == GridStringId.FilterBuilderApplyButton)
                    return "Áp dụng";
                if (id == GridStringId.FilterBuilderCancelButton)
                    return "Hủy bỏ";
                if (id == GridStringId.MenuColumnAutoFilterRowShow)
                    return "Hiện hàng lọc tự động";
                if (id == GridStringId.MenuColumnAutoFilterRowHide)
                    return "Ẩn hàng lọc tự động";
                if (id == GridStringId.MenuColumnFilterMode)
                    return "Chế độ lọc";
                if (id == GridStringId.MenuColumnFilterModeDisplayText)
                    return "Văn bản";
                if (id == GridStringId.MenuColumnFilterModeValue)
                    return "Giá trị";
                if (id == GridStringId.CustomFilterDialogCancelButton)
                    return "Hủy bỏ";
                //if (id == GridStringId.CustomFilterDialog2FieldCheck)
                //    return "2FieldCheck";
                if (id == GridStringId.CustomFilterDialogCaption)
                    return "Hiển thị những hàng có:";
                //if (id == GridStringId.CustomFilterDialogClearFilter)
                //    return "Clear";
                if (id == GridStringId.CustomFilterDialogEmptyOperator)
                    return "(Chọn phép toán)";
                if (id == GridStringId.CustomFilterDialogEmptyValue)
                    return "(Điền giá trị)";
                if (id == GridStringId.CustomFilterDialogFormCaption)
                    return "Tùy chọn lọc tự động";
                //if (id == GridStringId.CustomFilterDialogHint)
                //    return "fil hint";
                if (id == GridStringId.CustomFilterDialogOkButton)
                    return "Đồng ý";
                if (id == GridStringId.CustomFilterDialogRadioAnd)
                    return "Và";
                if (id == GridStringId.CustomFilterDialogRadioOr)
                    return "Hoặc";
                return base.GetLocalizedString(id);
            }
        }
        /// <summary>
        /// Thêm trường STT cho gridview
        /// </summary>
        /// <param name="gridview1"></param>
        public static GridView AddRowNumber(this GridView gridview1, int minwidth=45, int maxwidth=55, bool fixedleft=false)
        {
            DevExpress.XtraGrid.Columns.GridColumn colSTT_nvn = new DevExpress.XtraGrid.Columns.GridColumn();
            colSTT_nvn.AppearanceHeader.Options.UseFont = true;
            colSTT_nvn.AppearanceHeader.Options.UseTextOptions = true;
            colSTT_nvn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colSTT_nvn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colSTT_nvn.AppearanceCell.Options.UseTextOptions = true;
            colSTT_nvn.Caption = "STT";
            colSTT_nvn.AppearanceHeader.Font = new System.Drawing.Font(colSTT_nvn.AppearanceHeader.Font, System.Drawing.FontStyle.Bold);
            colSTT_nvn.Width = minwidth;
            colSTT_nvn.MinWidth = minwidth;
            //colSTT_nvn.Width = 50;
            colSTT_nvn.MaxWidth = maxwidth;
            colSTT_nvn.OptionsColumn.AllowEdit = false;
            colSTT_nvn.VisibleIndex = 0;
            Random rad = new Random();
            colSTT_nvn.Name = "colStt.123" + rad.Next(1000);

            foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridview1.Columns.Where(p => p.VisibleIndex >= 0).OrderBy(p => p.VisibleIndex))
            {
                if (c.VisibleIndex >= 0)
                    c.VisibleIndex = c.VisibleIndex + 1;
            }

            gridview1.Columns.Add(colSTT_nvn);
            gridview1.CustomDrawCell += (s1, e1) =>
            {
                if (e1.Column == colSTT_nvn)
                {
                    if (e1.RowHandle >= 0)
                        e1.DisplayText = (e1.RowHandle + 1).ToString();
                    else
                        e1.DisplayText = "*";
                }
            };
            if (fixedleft)
                colSTT_nvn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            colSTT_nvn.VisibleIndex = 0;
            return gridview1;
        }
        
        public static BandedGridView AddRowNumber(this BandedGridView gridview1, int minwidth = 45, int maxwidth = 55)
        {
            BandedGridColumn colSTT_nvn = new BandedGridColumn();
            colSTT_nvn.AppearanceHeader.Options.UseFont = true;
            colSTT_nvn.AppearanceHeader.Options.UseTextOptions = true;
            colSTT_nvn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colSTT_nvn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colSTT_nvn.AppearanceCell.Options.UseTextOptions = true;
            colSTT_nvn.Caption = "STT";
            colSTT_nvn.AppearanceHeader.Font = new System.Drawing.Font(colSTT_nvn.AppearanceHeader.Font, System.Drawing.FontStyle.Bold);
            colSTT_nvn.Width = minwidth;
            colSTT_nvn.MinWidth = minwidth;
            colSTT_nvn.Width = 50;
            colSTT_nvn.MinWidth = 30;
            colSTT_nvn.MaxWidth = maxwidth;
            colSTT_nvn.OptionsColumn.AllowEdit = false;
            colSTT_nvn.VisibleIndex = 0;
            Random rad = new Random();
            colSTT_nvn.Name = "colStt.123" + rad.Next(1000);

            foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridview1.Columns.Where(p => p.VisibleIndex >= 0).OrderBy(p => p.VisibleIndex))
            {
                if (c.VisibleIndex >= 0)
                    c.VisibleIndex = c.VisibleIndex + 1;
            }

            gridview1.Columns.Add(colSTT_nvn);
            gridview1.CustomDrawCell += (s1, e1) =>
            {
                if (e1.Column == colSTT_nvn)
                {
                    if (e1.RowHandle >= 0)
                        e1.DisplayText = (e1.RowHandle + 1).ToString();
                }
            };
            colSTT_nvn.VisibleIndex = 0;
            return gridview1;
        }

        public static GridView AddDeleteRowButton(this GridView grv, EventHandler action_xoa)
        {
            RepositoryItemHyperLinkEdit rep_colXoa = new RepositoryItemHyperLinkEdit();
            rep_colXoa.AutoHeight = false;
            rep_colXoa.Name = "rep_colXoa";
            rep_colXoa.NullText = "Xóa";
            rep_colXoa.Click += action_xoa;

            DevExpress.XtraGrid.Columns.GridColumn colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            colXoa.AppearanceCell.Options.UseTextOptions = true;
            colXoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colXoa.ColumnEdit = rep_colXoa;
            colXoa.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            colXoa.MaxWidth = 35;
            colXoa.MinWidth = 35;
            colXoa.Name = "colXoa";
            colXoa.Visible = true;
            colXoa.VisibleIndex = grv.Columns.Count;
            colXoa.Width = 35;

            grv.Columns.Add(colXoa);
            return grv;
        }

        public static GridView AddcolumnWithHyperLink(this GridView grv, string header_text, string display_text, EventHandler action_click, int min_width=55, int max_width=65)
        {
            RepositoryItemHyperLinkEdit rep_colHyperLink = new RepositoryItemHyperLinkEdit();
            rep_colHyperLink.AutoHeight = false;
            rep_colHyperLink.Name = $"rep_colHyperLink{grv.Columns.Count}";
            rep_colHyperLink.NullText = display_text;
            rep_colHyperLink.Click += action_click;

            GridColumn colHyperLink = new GridColumn();
            colHyperLink.Caption = header_text;
            colHyperLink.AppearanceCell.Options.UseTextOptions = true;
            colHyperLink.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colHyperLink.ColumnEdit = rep_colHyperLink;
            colHyperLink.Fixed = FixedStyle.Right;
            colHyperLink.MaxWidth = min_width;
            colHyperLink.MinWidth = max_width;
            colHyperLink.Name = $"colcolHyperLink{grv.Columns.Count}";
            colHyperLink.Visible = true;
            colHyperLink.VisibleIndex = grv.Columns.Count;
            colHyperLink.Width = 35;

            grv.Columns.Add(colHyperLink);
            return grv;
        }
    }
}
