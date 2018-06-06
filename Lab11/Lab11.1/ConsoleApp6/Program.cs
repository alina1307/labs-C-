using System;

namespace Lab11._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            ElementParallelMainDiagonal searcher = new ElementParallelMainDiagonal();
            int [,] arr = searcher.Input(rows,columns);
            searcher.SumElementsAboveMainDiagonal(arr);
            searcher.SumElementsBelowMainDiagonal(arr);
            searcher.SumMainDiagonal(arr);
        }
    }
}
