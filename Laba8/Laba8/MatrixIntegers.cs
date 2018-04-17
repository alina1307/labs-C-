using System.Collections.Generic;

namespace Laba8
{
    class MatrixIntegers
    {
        public List<List<int>> Matrix { get; }
        private List<int> insertableColumn;

        public MatrixIntegers(List<List<int>> matrix)
        {
            Matrix = matrix;
        }

        public void InsertColumns()
        {
            GetInsertableColumn();

            for (int numberColumn = 0; numberColumn < Matrix.Count; numberColumn++)
            {
                if (FindEvenNegativeNumber(numberColumn))
                {
                    Matrix.Insert(++numberColumn, insertableColumn);
                }
            }
        }

        private bool FindEvenNegativeNumber(int numberColumn)
        {
            foreach (int number in Matrix[numberColumn])
            {
                if ((number < 0) && (number % 2 == 0))
                {
                    return true;
                }
            }
            return false;
        }

        private void GetInsertableColumn()
        {
            int numberMaxColumn = FindMaxValue();
            int numberMinColumn = FindMinValue();
            insertableColumn = new List<int>();

            for (int i = 0; i < Matrix.Count; i++)
            {
                insertableColumn.Add(Matrix[numberMaxColumn][i] - Matrix[numberMinColumn][i]);
            }
        }

        private int FindMinValue()
        {
            int minValue = int.MaxValue;
            int numberColumn = -1;

            for (int i = 0; i < Matrix.Count; i++)
            {
                foreach (int number in Matrix[i])
                {
                    if (number < minValue)
                    {
                        minValue = number;
                        numberColumn = i;
                    }
                }
            }
            return numberColumn;
        }

        private int FindMaxValue()
        {
            int maxValue = int.MinValue;
            int numberColumn = -1;

            for (int i = 0; i < Matrix.Count; i++)
            {
                foreach (int number in Matrix[i])
                {
                    if (number > maxValue)
                    {
                        maxValue = number;
                        numberColumn = i;
                    }
                }
            }
            return numberColumn;
        }
    }
}
