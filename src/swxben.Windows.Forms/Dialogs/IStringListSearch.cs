using System.Collections.Generic;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public interface IStringListSearch
    {
        string SelectedItem { get; set; }
        void SetValues(string title, IEnumerable<string> source);
        DialogResult ShowDialog();
        void FixWidth();
    }
}
