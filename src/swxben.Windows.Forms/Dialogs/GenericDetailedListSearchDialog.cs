using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using swxben.Windows.Forms.Controls;

namespace swxben.Windows.Forms.Dialogs
{
    public partial class GenericDetailedListSearchDialog<T> : Form, IGenericDetailedListSearch<T>
    {
        private const string FilterPrompt = "Search...";

        IEnumerable<T> _source;
        bool _loading;
        Func<T, IEnumerable<string>> _displayCallback;

        public virtual T SelectedItem
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

        public GenericDetailedListSearchDialog()
        {
            InitializeComponent();
        }

        public GenericDetailedListSearchDialog(string title, IEnumerable<T> source, IEnumerable<string> columns, Func<T, IEnumerable<string>> displayCallback)
        {
            InitializeComponent();
            SetValues(title, source, columns, displayCallback);
        }

        public void SetValues(string title, IEnumerable<T> source, IEnumerable<string> columns, Func<T, IEnumerable<string>> displayCallback)
        {
            Text = title;
            _source = source;
            _displayCallback = displayCallback;

            LoadControl(columns);
            RefreshControl();
        }

        void LoadControl(IEnumerable<string> columns)
        {
            _loading = true;
            ListViewItemTextComparer.AssignTo(GenericListView);
            GenericListView.Columns.Clear();
            GenericListView.Columns.AddRange(columns.Select(c => new ColumnHeader { Text = c }).ToArray());
            Filter("");
            SearchTextBox.SetWatermark(FilterPrompt);
            _loading = false;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_loading) return;
            Filter(SearchTextBox.Text);
        }

        void RefreshControl()
        {
            SelectItemButton.Enabled = GenericListView.SelectedItems.Count != 0;
        }

        void Filter(string filter)
        {
            GenericListView.BeginUpdate();
            GenericListView.Items.Clear();
            var matches = _source
                .Where(s => string.IsNullOrEmpty(filter) || _displayCallback(s).Any(c => c.ToLower().Contains(filter.ToLower())));
            GenericListView.Items.AddRange(
                matches.Select(s =>
                    {
                        var i = new ListViewItem();
                        var columns = _displayCallback(s).ToArray();
                        i.Text = columns.First();
                        i.SubItems.AddRange(columns.Skip(1).ToArray());
                        i.Tag = s;
                        return i;
                    }).ToArray());
            GenericListView.EndUpdate();

            GenericListView.AutoResizeColumnsSmart();
            if (GenericListView.Items.Count > 0) GenericListView.Items[0].Selected = true;
            RefreshControl();
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

        public void Sort()
        {
            GenericListView.Sort();
        }
    }
}
