using System;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public partial class DateRangePromptDialog : Form, IDateRangePrompt
    {
        public DateTime FromValue
        {
            get { return InputFromDateTimePicker.Value; }
            set { InputFromDateTimePicker.Value = value; }
        }

        public DateTime ToValue
        {
            get { return InputToDateTimePicker.Value; }
            set { InputToDateTimePicker.Value = value; }
        }

        public void SetMinDate(DateTime minDate)
        {
            InputFromDateTimePicker.MinDate = minDate;
            InputToDateTimePicker.MinDate = minDate;
        }

        public void SetMaxDate(DateTime maxDate)
        {
            InputFromDateTimePicker.MaxDate = maxDate;
            InputToDateTimePicker.MaxDate = maxDate;
        }

        public DateRangePromptDialog()
        {
            InitializeComponent();
            SetValues("Enter a value:", "", DateTime.Now.Date, DateTime.Now.Date);
        }

        public DateRangePromptDialog(string prompt)
        {
            InitializeComponent();
            SetValues(prompt, "", DateTime.Now.Date, DateTime.Now.Date);
        }

        public DateRangePromptDialog(string prompt, string caption)
        {
            InitializeComponent();
            SetValues(prompt, caption, DateTime.Now.Date, DateTime.Now.Date);
        }

        public DateRangePromptDialog(string prompt, string caption, DateTime defaultFromValue, DateTime defaultToValue)
        {
            InitializeComponent();
            SetValues(prompt, caption, defaultFromValue, defaultToValue);
        }

        public void SetValues(string prompt, string caption, DateTime defaultFromValue, DateTime defaultToValue)
        {
            PromptLabel.Text = prompt;
            Text = caption;
            InputFromDateTimePicker.Value = defaultFromValue;
            InputToDateTimePicker.Value = defaultToValue;
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

        private void InputFromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            InputToDateTimePicker.MinDate = InputFromDateTimePicker.Value;
        }

        private void InputToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            InputFromDateTimePicker.MaxDate = InputToDateTimePicker.Value;
        }
    }
}
