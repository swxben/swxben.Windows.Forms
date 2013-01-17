using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace swxben.Windows.Forms
{
    public class ListViewItemTextComparer : IComparer
    {
        public enum ColumnFormat
        {
            Tag,
            Text,
            Date,
            Numeric,
            Currency,
            Percentage,
            NumericUnit
        }

        public static void AssignTo(ListView listView, params ColumnFormat[] formats)
        {
            var comparer = new ListViewItemTextComparer(listView);
            comparer.AddColumnFormats(formats);
        }

        readonly Regex DECIMAL_REGEX = new Regex(@"[^\d]");

        int _sortColumn;
        ArrayList _columnFormats = new ArrayList();
        readonly Hashtable _columnSortOrders = new Hashtable();
        int _secondSortColumn = -1;
        readonly ListView _listView;

        public int SortColumn
        {
            get { return _sortColumn; }
            set
            {
                _sortColumn = value;
                SortDescending = !SortDescending;
            }
        }

        public bool SortDescending
        {
            get
            {
                if (_columnSortOrders.ContainsKey(_sortColumn)) return (bool)_columnSortOrders[_sortColumn];

                _columnSortOrders[_sortColumn] = false;
                return true;
            }
            set
            {
                if (_columnSortOrders.ContainsKey(_sortColumn)) _columnSortOrders[_sortColumn] = value;
                else _columnSortOrders.Add(_sortColumn, value);
            }
        }

        public ArrayList ColumnFormats { get { return _columnFormats; } }

        public int SecondSortColumn
        {
            get { return _secondSortColumn; }
            set { _secondSortColumn = value; }
        }

        public ListViewItemTextComparer SetSortColumn(int i)
        {
            SortColumn = i;
            return this;
        }

        public ListViewItemTextComparer SetSortDescending(bool b)
        {
            SortDescending = b;
            return this;
        }

        public ListViewItemTextComparer SetSecondSortColumn(int i)
        {
            SecondSortColumn = i;
            return this;
        }

        public ListViewItemTextComparer()
        {
        }

        public ListViewItemTextComparer(int sortColumn)
        {
            _sortColumn = sortColumn;
        }

        public ListViewItemTextComparer(int sortColumn, bool sortDescending)
        {
            _sortColumn = sortColumn;
            SortDescending = sortDescending;
        }

        public ListViewItemTextComparer(ListView v)
        {
            _listView = v;
            _listView.ListViewItemSorter = this;
            _listView.ColumnClick += listView_ColumnClick;
        }

        public int Compare(object x, object y)
        {
            var itemX = x as ListViewItem;
            var itemY = y as ListViewItem;

            if (itemX == null || itemY == null) return -1;

            if (_sortColumn >= itemX.SubItems.Count) return -1;
            if (_sortColumn >= itemY.SubItems.Count) return -1;

            var xValue = itemX.SubItems[_sortColumn].Text;
            var yValue = itemY.SubItems[_sortColumn].Text;
            var compareValue = 0;
            var columnFormat = ColumnFormat.Text;

            if (_sortColumn < _columnFormats.Count)
            {
                try { columnFormat = (ColumnFormat)_columnFormats[_sortColumn]; }
                // ReSharper disable EmptyGeneralCatchClause
                catch { }
                // ReSharper restore EmptyGeneralCatchClause
            }

            // Special case, if the column format isn't tag and any string is empty, it shouldn't be parsed
            if (columnFormat != ColumnFormat.Tag)
            {
                if (xValue == "" && yValue == "") return 0;
                if (xValue == "") return SortDescending ? 1 : -1;
                if (yValue == "") return SortDescending ? -1 : 1;
            }

            // If the column format is percentage, strip any whitespace and '%' from the value and
            // change the column format to numeric
            if (columnFormat == ColumnFormat.Percentage)
            {
                xValue = xValue.Replace("%", "").Trim();
                yValue = yValue.Replace("%", "").Trim();
                columnFormat = ColumnFormat.Numeric;
            }

            if (columnFormat == ColumnFormat.NumericUnit)
            {
                xValue = DECIMAL_REGEX.Replace(xValue, "");
                yValue = DECIMAL_REGEX.Replace(yValue, "");
                columnFormat = ColumnFormat.Numeric;
            }

            try
            {
                compareValue = CompareValues(columnFormat, xValue, yValue, itemX, itemY);
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch { }
            // ReSharper restore EmptyGeneralCatchClause

            if (compareValue == 0 && _secondSortColumn != -1 && _secondSortColumn != _sortColumn)
            {
                var comparer = new ListViewItemTextComparer
                    {
                        _columnFormats = _columnFormats,
                        SortColumn = _secondSortColumn
                    };
                compareValue = comparer.Compare(x, y);
            }

            return compareValue != 0 ? (SortDescending ? -compareValue : compareValue) : 1;
        }

        private static int CompareValues(ColumnFormat columnFormat, string xValue, string yValue, ListViewItem itemX, ListViewItem itemY)
        {
            if (columnFormat == ColumnFormat.Text) return String.Compare(xValue, yValue, StringComparison.Ordinal);
            if (columnFormat == ColumnFormat.Date) return CompareDates(xValue, yValue);
            if (columnFormat == ColumnFormat.Numeric) return CompareNumeric(xValue, yValue);
            if (columnFormat == ColumnFormat.Currency) return CompareCurrency(xValue, yValue);
            if (columnFormat == ColumnFormat.Tag) return CompareTags(itemX, itemY);

            return 0;
        }

        private static int CompareTags(ListViewItem itemX, ListViewItem itemY)
        {
            if (itemX.Tag == null || itemY.Tag == null || !(itemX.Tag is IComparable) || !(itemY.Tag is IComparable))
            {
                return 0;
            }

            var xTag = (IComparable)itemX.Tag;
            var yTag = (IComparable)itemY.Tag;

            return -xTag.CompareTo(yTag);
        }

        private static int CompareCurrency(string xValue, string yValue)
        {
            var xDecimal = decimal.MinValue;
            var yDecimal = decimal.MinValue;
            try
            {
                xDecimal = decimal.Parse(xValue, System.Globalization.NumberStyles.Currency);
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch
            {
            }
            // ReSharper restore EmptyGeneralCatchClause
            try
            {
                yDecimal = decimal.Parse(yValue, System.Globalization.NumberStyles.Currency);
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch
            {
            }
            // ReSharper restore EmptyGeneralCatchClause
            return xDecimal.CompareTo(yDecimal);
        }

        private static int CompareNumeric(string xValue, string yValue)
        {
            var xDouble = double.MinValue;
            var yDouble = double.MinValue;
            try
            {
                xDouble = Convert.ToDouble(xValue);
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch
            {
            }
            // ReSharper restore EmptyGeneralCatchClause
            try
            {
                yDouble = Convert.ToDouble(yValue);
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch
            {
            }
            // ReSharper restore EmptyGeneralCatchClause
            return xDouble.CompareTo(yDouble);
        }

        private static int CompareDates(string xValue, string yValue)
        {
            var xDateTime = DateTime.MinValue;
            var yDateTime = DateTime.MinValue;
            try
            {
                xDateTime = DateTime.Parse(xValue);
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch
            {
            }
            // ReSharper restore EmptyGeneralCatchClause
            try
            {
                yDateTime = DateTime.Parse(yValue);
            }
            // ReSharper disable EmptyGeneralCatchClause
            catch
            {
            }
            // ReSharper restore EmptyGeneralCatchClause
            return xDateTime.CompareTo(yDateTime);
        }

        public ListViewItemTextComparer AddColumnFormats(params ColumnFormat[] formats)
        {
            foreach (var f in formats)
            {
                _columnFormats.Add(f);
            }
            return this;
        }

        void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortColumn = e.Column;
            _listView.Sort();
        }
    }
}