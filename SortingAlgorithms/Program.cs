using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                input[i] = rnd.Next(0,100);
            }

            ISort<int> sorting = new InsertionSort<int>();
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("After sorting");
            sorting.Sort(input);
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
