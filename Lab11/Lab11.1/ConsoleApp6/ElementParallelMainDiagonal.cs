using System;

namespace Lab11._1
{
    class ElementParallelMainDiagonal
    {
        public int[,] Input(int rows, int columns)
        {
            int[,] arr = new int[rows, columns];
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(0, 21);
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            return arr;
        }

        public void SumElementsAboveMainDiagonal(int [,] arr)
        {
            Console.WriteLine("\n сумма элементов массива, расположенных параллельно и выше главной диагонали: ");
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                int sum1 = 0;
                for (int j = i + 1; j < arr.GetLength(1); j++)
                {
                    sum1 += arr[j - i - 1, j];
                }
                Console.Write($" {sum1} ");
            }
        }

        public void SumElementsBelowMainDiagonal(int [,] arr)
        {
            Console.Write("\n сумма элементов массива, расположенных параллельно и ниже главной диагонали: ");
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                int sum2 = 0;
                for (int j = i + 1; j < arr.GetLength(1); j++)
                {
                    sum2 += arr[j, j - i - 1];
                }
                Console.Write($" {sum2} ");
            }
        }

        public void SumMainDiagonal(int[,] arr)
        {
            Console.Write("\n сумма элементов массива, расположенных на главной диагонали: ");
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[i, i];
            }
            Console.Write($" {sum} ");
            Console.ReadKey();
        }
    }
}
