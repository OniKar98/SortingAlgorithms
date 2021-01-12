using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BubbleSort<T> : SortBase<T>,ISort<T>  where T : IComparable
    {
        public void Sort(T[] input)
        {
            var count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                count++;
                var isValueSwapped = false;
                for (int j = 0; j < input.Length - 1 - i; j++)
                {
                    if (IsSmall(input[j], input[ j +1])==false)
                    {
                        Swap(j, j + 1, input);
                        isValueSwapped = true;
                    }
                }
                if (isValueSwapped == false)
                {
                    Console.WriteLine("break");
                    Console.WriteLine("{0} iterations occured", count);
                    return;
                }
            }
            Console.WriteLine("full");
            Console.WriteLine("{0} iterations occured", count);
        }        

    }
}
