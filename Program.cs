using StrategyPattern;
using StrategyPattern.SortStrategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {


            SortedList context = new SortedList(new MergeSort());
            context.Add("4");
            context.Add("2");
            context.Add("88");

            context.Sort();

            context.SetSortStrategy(new BubbleSort());

            context.Sort();

            Console.WriteLine("Hello World!");
        }
    }
}
