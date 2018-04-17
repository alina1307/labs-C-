using System;

namespace Laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            SortingDecreasingOrder searcher = new SortingDecreasingOrder();
            int[,] mas = searcher.Input(rows, columns);
            int[,] arr = searcher.SortRow(mas);
            searcher.Output(arr);
            searcher.SortCol(arr);
            searcher.Output(arr);
            Console.Read();  
            }
        }
    }

