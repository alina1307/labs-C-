using System;
using System.Collections.Generic;

namespace lab5
{
    class Max
    {
        public List<int> SearchTheMaximum(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] < list[i] && list[i] > list[i + 1])
                {
                    list.Insert(i + 1, list[i]);
                }
            }
            return list;
        }

        public void Output(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.Read();
        }
    }
}
