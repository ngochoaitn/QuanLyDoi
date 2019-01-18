using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNguoiNuocNgoai.Class
{
    internal class ThaoTacNhanh
    {

        private static IEnumerable<Control> GetAllControl(Control control)
        {
            List<Control> res = new List<Control>();
            foreach (Control c in control.Controls)
            {
                if (c is LayoutControl || c is UserControl || c is PanelControl)
                    res.AddRange(GetAllControl(c));
                else
                    res.Add(c);
            }
            return res;
        }


        public static void EnterToNextControl(Control control, bool enter_to_next = true, bool bold_focus = true)
        {
            foreach (var c in GetAllControl(control))
            {
                if (c is TextEdit && c.GetType() != typeof(MemoEdit))
                {
                    TextEdit txt = c as TextEdit;
                    txt.EnterMoveNextControl = enter_to_next;
                    if (bold_focus)
                    {
                        txt.Properties.AppearanceFocused.ForeColor = Color.Blue;
                        System.Drawing.Font font = txt.Properties.AppearanceFocused.Font;
                        font = new System.Drawing.Font(font.FontFamily, font.Size, FontStyle.Bold);
                        txt.Properties.AppearanceFocused.Font = font;
                    }
                }
            }
        }

        public static void EnterToSelectFirstRow(Control control)
        {
            foreach (Control c in GetAllControl(control))
                if (c is SearchLookUpEdit)
                    EnterToSelectFirstRow(c as SearchLookUpEdit);
        }

        public static void EnterToSelectFirstRow(SearchLookUpEdit slu)
        {
            slu.Popup += (s1, e1) =>
            {
                PopupSearchLookUpEditForm popupForm = (s1 as IPopupControl).PopupWindow as PopupSearchLookUpEditForm;
                popupForm.KeyPreview = true;
                popupForm.KeyUp -= popupForm_KeyUp;
                popupForm.KeyUp += popupForm_KeyUp;
            };
        }

        public static void EnterToSelectFirstRow(RepositoryItemSearchLookUpEdit slu)
        {
            slu.Popup += (s1, e1) =>
            {
                PopupSearchLookUpEditForm popupForm = (s1 as IPopupControl).PopupWindow as PopupSearchLookUpEditForm;
                popupForm.KeyPreview = true;
                popupForm.KeyUp -= popupForm_KeyUp;
                popupForm.KeyUp += popupForm_KeyUp;
            };
        }

        static void popupForm_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            PopupSearchLookUpEditForm popupForm = sender as PopupSearchLookUpEditForm;
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                GridView view = popupForm.OwnerEdit.Properties.View;
                view.FocusedRowHandle = 0;
                view.SelectRow(0);
                popupForm.OwnerEdit.ClosePopup();
            }
        }

        public static void EnterToSelectFirstRow(GridView grv)
        {
            foreach (GridColumn col in grv.Columns)
                if (col.ColumnEdit is RepositoryItemSearchLookUpEdit)
                    EnterToSelectFirstRow(col.ColumnEdit as RepositoryItemSearchLookUpEdit);
                else if (col.ColumnEdit is RepositoryItemDateEdit)
                    (col.ColumnEdit as RepositoryItemDateEdit).Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
        }

        public static void EnterToNext_Bold_EnterSelect(Control control, bool enter_to_next = true, bool bold_focus = true)
        {
            foreach (var c in GetAllControl(control))
            {
                if (c is TextEdit && c.GetType() != typeof(MemoEdit))
                {
                    TextEdit txt = c as TextEdit;
                    txt.EnterMoveNextControl = enter_to_next;
                    if (bold_focus)
                    {
                        txt.Properties.AppearanceFocused.ForeColor = Color.Blue;
                        System.Drawing.Font font = txt.Properties.AppearanceFocused.Font;
                        font = new System.Drawing.Font(font.FontFamily, font.Size, FontStyle.Bold);
                        txt.Properties.AppearanceFocused.Font = font;
                    }
                }
                if (c is SearchLookUpEdit)
                    EnterToSelectFirstRow(c as SearchLookUpEdit);
                if (c is GridControl && (c as GridControl).MainView is GridView)
                    EnterToSelectFirstRow((c as GridControl).MainView as GridView);
                if (c is DateEdit)
                    (c as DateEdit).Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            }
        }
    }
}
