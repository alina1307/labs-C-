using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            ArraySorting searcher = new ArraySorting();
            int[] arr = searcher.InputArray();
            searcher.Permutation(arr, number);
            Console.Read();
        }
    }
}