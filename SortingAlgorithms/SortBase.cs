using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    abstract class SortBase<T> where T : IComparable
    {
        public bool IsSmall(T i, T j)
        {
            return i.CompareTo(j) <= 0;
        }

        public void Swap(int i, int j, T[] input)
        {
            var temp = input[j];
            input[j] = input[i];
            input[i] = temp;
        }
    }
}
