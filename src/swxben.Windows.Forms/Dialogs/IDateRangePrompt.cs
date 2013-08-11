using System;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public interface IDateRangePrompt
    {
        DateTime FromValue { get; set; }
        DateTime ToValue { get; set; }
        void SetMinDate(DateTime minDate);
        void SetMaxDate(DateTime maxDate);
        void SetValues(string prompt, string caption, DateTime defaultFromValue, DateTime defaultToValue);
        DialogResult ShowDialog();
    }
}
