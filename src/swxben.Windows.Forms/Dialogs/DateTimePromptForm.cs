using System;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public partial class DateTimePromptForm : Form, IDateTimePrompt
    {
        public DateTime Value
        {
            get { return InputDateTimePicker.Value; }
            set { InputDateTimePicker.Value = value; }
        }

        public void SetMinDate(DateTime minDate)
        {
            InputDateTimePicker.MinDate = minDate;
        }

        public DateTimePromptForm()
        {
            InitializeComponent();
            SetValues("Enter a value:", "", DateTime.Now.Date);
        }

        public DateTimePromptForm(string prompt)
        {
            InitializeComponent();
            SetValues(prompt, "", DateTime.Now.Date);
        }

        public DateTimePromptForm(string prompt, string caption)
        {
            InitializeComponent();
            SetValues(prompt, caption, DateTime.Now.Date);
        }

        public DateTimePromptForm(string prompt, string caption, DateTime defaultValue)
        {
            InitializeComponent();
            SetValues(prompt, caption, defaultValue);
        }

        public void SetValues(string prompt, string caption, DateTime defaultValue)
        {
            PromptLabel.Text = prompt;
            Text = caption;
            InputDateTimePicker.Value = defaultValue;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelPromptButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void InputDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
