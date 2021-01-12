using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class InsertionSort<T> : SortBase<T>, ISort<T> where T : IComparable
    {
        public void Sort(T[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                var currentValue = input[i];
                var j = i - 1;
                while (j>=0 && IsSmall(input[j], currentValue) == false)
                {
                    Swap(j + 1, j, input);
                    j--;
                }
                input[j + 1] = currentValue;
                foreach (var item in input)
                {
                    Console.Write(item+"--");                    
                }
                Console.WriteLine();
            }
        }
    }
}
