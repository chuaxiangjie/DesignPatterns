using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.SortStrategy
{
    public class MergeSort : ISortStrategy
    {
        void ISortStrategy.Sort(List<string> items)
        {
            Console.WriteLine("Merge sort");
        }
    }
}
