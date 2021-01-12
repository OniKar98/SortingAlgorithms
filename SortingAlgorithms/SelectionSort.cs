using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SelectionSort<T> : SortBase<T>, ISort<T> where T : IComparable
    {
        public void Sort(T[] input)
        {
            T currentMin;
            int currentMinIndex = 0;
            var count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                count++;
                currentMin = input[i];
                currentMinIndex = i;
                for (int j = i+1; j < input.Length; j++)
                {
                    if (IsSmall(input[j], currentMin) == true)
                    {
                        currentMin = input[j];
                        currentMinIndex = j;
                    }
                }
                Swap(i, currentMinIndex,input);
            }
            Console.WriteLine("break");
            Console.WriteLine("{0} iterations occured", count);
        }
    }
}
