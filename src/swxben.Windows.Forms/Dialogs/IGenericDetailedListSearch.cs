﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace swxben.Windows.Forms.Dialogs
{
    public interface IGenericDetailedListSearch<T>
    {
        T SelectedItem { get; set; }
        void SetValues(
            string title, 
            IEnumerable<T> source, 
            IEnumerable<string> columns, 
            Func<T, IEnumerable<string>> displayCallback);

        void SetValues(
            string title,
            IEnumerable<T> source,
            IEnumerable<string> columns,
            Func<T, IEnumerable<string>> displayCallback,
            IEnumerable<ListViewItemTextComparer.ColumnFormat> columnFormats);

        DialogResult ShowDialog();
        void FixWidth();
        void Sort();
    }
}
