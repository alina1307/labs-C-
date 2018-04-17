using System;
using System.Collections.Generic;

namespace Laba8
{
    class Output
    {
        public void Matrix(List<List<int>> matrix)
        {
            for (int i = 0; i < matrix[0].Count; i++)
            {
                for (int j = 0; j < matrix.Count; j++)
                {
                    Console.Write(String.Format("{0,4:0}", matrix[j][i]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
