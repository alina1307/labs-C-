using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    class LongString
    {
        public List<int> DeletingALongString () {
            Random r = new Random();
            List<int> list = Enumerable.Range(0, 10).Select(n => r.Next(1, 10)).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            int count = 1;
            int firstNumber = 0;
            int max = 0, index = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] == list[i])
                {
                    count++;
                    if (max < count)
                    {
                        max = count;
                        index = firstNumber;
                    }
                }
                else
                {
                    count = 1;
                    firstNumber = i;
                }
            }
            list.RemoveRange(index, max);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.Read();
            return list;
        }
    }
}
