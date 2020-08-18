using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.SortStrategy
{
    public class BubbleSort : ISortStrategy
    {
        void ISortStrategy.Sort(List<string> items)
        {
            Console.WriteLine("Bubble sort");
        }
    }
}
