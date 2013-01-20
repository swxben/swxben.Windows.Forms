using System.Windows.Forms;

namespace swxben.Windows.Forms.Controls
{
    public static class ListViewAutoResizeColumnsSmartExtension
    {
        public static void AutoResizeColumnsSmart(this ListView listView)
        {
            foreach (ColumnHeader header in listView.Columns)
            {
                header.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                var headerWidth = header.Width;
                header.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                var contentWidth = header.Width;

                header.Width = headerWidth > contentWidth ? headerWidth : contentWidth;
            }
        }
    }
}
