using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public interface IGenericListSearch<T>
    {
        T SelectedItem { get; set; }
        void SetValues(string title, IEnumerable<T> source, Func<T, string> displayCallback);
        DialogResult ShowDialog();
        void FixWidth();
        void Sort();
    }
}
