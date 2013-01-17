using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public interface ITextPrompt
    {
        string Value { get; set; }
        void SetValues(string prompt, string caption, string defaultValue);
        DialogResult ShowDialog();
    }
}
