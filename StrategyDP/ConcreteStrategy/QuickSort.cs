using StrategyDP.Strategy;
using System;
using System.Collections.Generic;

namespace StrategyDP.ConcreteStrategy
{
    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Console.WriteLine("quickSorted list ");
        }
    }
}