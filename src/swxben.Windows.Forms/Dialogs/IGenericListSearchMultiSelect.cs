using System.Collections.Generic;

namespace swxben.Windows.Forms.Dialogs
{
    public interface IGenericListSearchMultiSelect<T> : IGenericListSearch<T>
    {
        IEnumerable<T> SelectedItems { get; }
    }
}
