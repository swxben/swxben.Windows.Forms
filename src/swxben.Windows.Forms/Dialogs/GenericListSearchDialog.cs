using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public partial class GenericListSearchDialog<T> : Form, IGenericListSearch<T>
    {
        private const string FILTER_PROMPT = "Search...";

        IEnumerable<T> _source;
        bool _loading;
        Func<T, string> _displayCallback;

        public T SelectedItem
        {
            get
            {
                return GenericListView.SelectedItems.Cast<ListViewItem>().Select(i => (T)i.Tag).FirstOrDefault();
            }
            set
            {
                if (ReferenceEquals(value, null)) return;

                foreach (var item in GenericListView.Items.Cast<ListViewItem>().Where(i => i.Tag.Equals(value)))
                {
                    item.Selected = true;
                    item.EnsureVisible();
                    GenericListView.EnsureVisible(item.Index);
                }
            }
        }

        public GenericListSearchDialog()
        {
            InitializeComponent();
        }

        public GenericListSearchDialog(string title, IEnumerable<T> source, Func<T, string> displayCallback)
        {
            InitializeComponent();
            SetValues(title, source, displayCallback);
        }

        public void SetValues(string title, IEnumerable<T> source, Func<T, string> displayCallback)
        {
            Text = title;
            _source = source;
            _displayCallback = displayCallback;

            LoadControl();
            RefreshControl();
        }

        void LoadControl()
        {
            _loading = true;
            ListViewItemTextComparer.AssignTo(GenericListView);
            Filter("");
            SearchTextBox.Text = FILTER_PROMPT;
            _loading = false;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            Filter(SearchTextBox.Text);
        }

        void RefreshControl()
        {
            SearchTextBox.ForeColor = (SearchTextBox.Text == FILTER_PROMPT) ? Color.FromKnownColor(KnownColor.GrayText) : Color.FromKnownColor(KnownColor.ControlText);
            SelectItemButton.Enabled = GenericListView.SelectedItems.Count != 0;
        }

        void Filter(string filter)
        {
            GenericListView.BeginUpdate();
            GenericListView.Items.Clear();
            var matches = _source
                .Where(s => string.IsNullOrEmpty(filter) || _displayCallback(s).ToLower().Contains(filter.ToLower()));
            GenericListView.Items.AddRange(
                matches.Select(s => new ListViewItem { Text = _displayCallback(s), Tag = s }).ToArray());
            GenericListView.EndUpdate();

            GenericListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void FixWidth()
        {
            var newWidth = Width + GenericListView.Columns.Cast<ColumnHeader>().Sum(c => c.Width) - GenericListView.Width + 30;
            if (Width < newWidth) Width = newWidth;
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                SelectItem();
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.Handled = true;

                var currentIndex = 0;

                foreach (int index in GenericListView.SelectedIndices) currentIndex = index;
                var newIndex = currentIndex;
                if (e.KeyCode == Keys.Up) newIndex--;
                if (e.KeyCode == Keys.Down) newIndex++;
                if (newIndex < 0) newIndex = GenericListView.Items.Count - 1;
                else if (newIndex >= GenericListView.Items.Count) newIndex = 0;
                GenericListView.Items[currentIndex].Selected = false;
                GenericListView.Items[newIndex].Selected = true;
                GenericListView.Items[newIndex].EnsureVisible();
            }
        }

        private void StringListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != FILTER_PROMPT) return;
            _loading = true;
            SearchTextBox.Text = "";
            _loading = false;
            RefreshControl();
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "") return;
            _loading = true;
            SearchTextBox.Text = FILTER_PROMPT;
            _loading = false;
            RefreshControl();
        }

        private void StringListView_ItemActivate(object sender, EventArgs e)
        {
            SelectItem();
        }

        void SelectItem()
        {
            if (GenericListView.SelectedItems.Count == 0) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelSelectionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SelectItemButton_Click(object sender, EventArgs e)
        {
            SelectItem();
        }
    }
}
