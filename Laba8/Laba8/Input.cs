using System;
using System.Collections.Generic;

namespace Laba8
{
    class Input
    {
        public List<List<int>> GetMatrix(int numberLines, int numberColumns)
        {
            List<List<int>> matrix = new List<List<int>>();
            Random random = new Random();
            List<int> column;

            for (int i = 0; i < numberColumns; i++)
            {
                column = new List<int>();
                for (int j = 0; j < numberLines; j++)
                {
                    column.Add(random.Next(-10, 10));
                }
                matrix.Add(column);
            }
            return matrix;
        }
    }
}


