using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface ISortStrategy
    {
        void Sort(List<string> items);
    }
}
