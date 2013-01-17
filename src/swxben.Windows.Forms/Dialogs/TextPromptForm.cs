using System;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public partial class TextPromptForm : Form
    {
        public string Value
        {
            get { return InputTextBox.Text; }
            set { InputTextBox.Text = string.IsNullOrEmpty(value) ? " " : value; }
        }

        public TextPromptForm()
        {
            InitializeComponent();
            SetValues("Enter a value:", "", "");
        }

        public TextPromptForm(string prompt)
        {
            InitializeComponent();
            SetValues(prompt, "", "");
        }

        public TextPromptForm(string prompt, string caption)
        {
            InitializeComponent();
            SetValues(prompt, caption, "");
        }

        public TextPromptForm(string prompt, string caption, string defaultValue)
        {
            InitializeComponent();
            SetValues(prompt, caption, defaultValue);
        }

        void SetValues(string prompt, string caption, string defaultValue)
        {
            PromptLabel.Text = prompt;
            Text = caption;
            InputTextBox.Text = defaultValue;
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
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
    }
}
