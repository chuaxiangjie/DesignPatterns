using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class SortedList
    {
        private ISortStrategy _sortStrategy;
        private List<string> _names = new List<string>();

        public SortedList(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _names.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_names);
        }

    }
}
