using StrategyDP.Strategy;
using System;
using System.Collections.Generic;

namespace StrategyDP.ConcreteStrategy
{
    class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort();  not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
}