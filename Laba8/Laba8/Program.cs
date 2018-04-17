using System;
using System.Collections.Generic;

namespace Laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число строк: ");
            int numberLines = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число столбцов: ");
            int numberColumns = Convert.ToInt32(Console.ReadLine()); ;

            Input input = new Input();
            List<List<int>> values = input.GetMatrix(numberColumns, numberLines);

            Output output = new Output();
            output.Matrix(values);

            MatrixIntegers matrix = new MatrixIntegers(values);
            matrix.InsertColumns();
            output.Matrix(matrix.Matrix);

            Console.Read();
        }  
    }
}
