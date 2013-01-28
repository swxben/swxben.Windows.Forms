using System;
using System.Windows.Forms;

namespace swxben.Windows.Forms
{
    public partial class ExceptionForm : Form
    {
        public static void ShowException(string message, Exception exception)
        {
            var form = new ExceptionForm(message, exception);
            form.ShowDialog();
        }

        string _message;
        Exception _exception;

        public ExceptionForm()
        {
            InitializeComponent();
        }
        public ExceptionForm(string message, Exception exception)
        {
            InitializeComponent();

            _message = message;
            _exception = exception;

            LoadView();
            RefreshView();
        }

        void LoadView()
        {
            var text = _exception.Message;
            if (_message != "") text = string.Format("{0}{1}{1}{2}", _message, Environment.NewLine, text);
            exceptionTextBox.Text = text;
        }
        void RefreshView()
        {
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            var f = new ExceptionDetailsForm(_exception);
            f.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
