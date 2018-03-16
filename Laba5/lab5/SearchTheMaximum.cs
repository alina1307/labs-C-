using System;
using System.Collections.Generic;

namespace lab5
{
    class Max
    {
        public List<int> SearchTheMaximum()
        {
            List<int> list = new List<int>() { 1, 2, 3, 9, 4, 5, 3};
            for (int i = 1; i < list.Count - 1; i++)
            {
                if (list[i - 1] < list[i] && list[i] > list[i + 1])
                {
                    list.Insert(i + 1, list[i]);
                }
            }
            
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.Read();
            return list;
        }
    }
}
