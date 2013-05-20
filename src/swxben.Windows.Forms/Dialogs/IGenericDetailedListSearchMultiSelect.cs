using System.Collections.Generic;

namespace swxben.Windows.Forms.Dialogs
{
    public interface IGenericDetailedListSearchMultiSelect<T> : IGenericDetailedListSearch<T>
    {
        IEnumerable<T> SelectedItems { get; }
    }
}
