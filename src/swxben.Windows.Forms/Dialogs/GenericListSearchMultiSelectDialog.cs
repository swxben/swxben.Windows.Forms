using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public class GenericListSearchMultiSelectDialog<T> : GenericListSearchDialog<T>, IGenericListSearchMultiSelect<T>
    {
        public GenericListSearchMultiSelectDialog()
        {
            GenericListView.MultiSelect = true;
        }

        public GenericListSearchMultiSelectDialog(string title, IEnumerable<T> source, Func<T, string> displayCallback)
            : base(title, source, displayCallback)
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