using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public class GenericDetailedListSearchMultiSelectDialog<T> : GenericDetailedListSearchDialog<T>, IGenericDetailedListSearchMultiSelect<T>
    {
        public GenericDetailedListSearchMultiSelectDialog()
        {
            GenericListView.MultiSelect = true;
        }

        public GenericDetailedListSearchMultiSelectDialog(string title, IEnumerable<T> source, IEnumerable<string> columns, Func<T, IEnumerable<string>> displayCallback)
            : base(title, source, columns, displayCallback)
        {
            GenericListView.MultiSelect = true;
        }

        public IEnumerable<T> SelectedItems
        {
            get { return GenericListView.SelectedItems.Cast<ListViewItem>().Select(i => (T)i.Tag); }
        }

        public override T SelectedItem
        {
            get { return SelectedItems.FirstOrDefault(); }
            set { throw new NotImplementedException(); }
        }
    }
}