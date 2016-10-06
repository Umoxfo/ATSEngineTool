﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace ATSEngineTool
{
    public class MultipleListViewColumnSorter
    {
        private List<ListViewColumnSorterExt> sorters;

        public MultipleListViewColumnSorter()
        {
            sorters = new List<ListViewColumnSorterExt>();
        }

        public void AddListView(ListView lv)
        {
            sorters.Add(new ListViewColumnSorterExt(lv));
        }
    }
}
