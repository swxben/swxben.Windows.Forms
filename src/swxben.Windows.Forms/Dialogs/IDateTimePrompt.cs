using System;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public interface IDateTimePrompt
    {
        DateTime Value { get; set; }
        void SetMinDate(DateTime minDate);
        void SetMaxDate(DateTime maxDate);
        void SetValues(string prompt, string caption, DateTime defaultValue);
        DialogResult ShowDialog();
    }
}
