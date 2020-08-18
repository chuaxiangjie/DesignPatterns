using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.SortStrategy
{
    public class QuickSort : ISortStrategy
    {
        void ISortStrategy.Sort(List<string> items)
        {
            Console.WriteLine("Quick sort");
        }
    }
}
