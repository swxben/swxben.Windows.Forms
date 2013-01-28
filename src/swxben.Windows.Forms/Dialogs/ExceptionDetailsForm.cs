using System;
using System.Windows.Forms;

namespace swxben.Windows.Forms
{
    public partial class ExceptionDetailsForm : Form
    {
        public ExceptionDetailsForm()
        {
            InitializeComponent();
        }
        public ExceptionDetailsForm(Exception exception)
        {
            InitializeComponent();
            detailsTextBox.Text = exception.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(detailsTextBox.Text);
        }
    }
}
