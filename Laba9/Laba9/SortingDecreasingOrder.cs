using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba9
{
    class SortingDecreasingOrder
    {
        public int[,] Input(int rows, int columns)
        {
            Random r = new Random();
            int[,] arr = new int[rows, columns];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(0, 21);
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            return arr;
        }

        public int[,] SortRow(int[,] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    list.Add(arr[i, j]);
                }
                list = list.OrderByDescending(x => x).ToList();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = list[j];
                }
                list.Clear();
            }
            return arr;
        }

        public int[,] SortCol(int[,] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    list.Add(arr[j, i]);
                }
                list = list.OrderByDescending(x => x).ToList();
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[j, i] = list[j];
                }
                list.Clear();
            }
            return arr;
        }

        public void Output(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
