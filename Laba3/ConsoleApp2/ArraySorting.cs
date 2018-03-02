using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class ArraySorting
    {
        public List<int> Input()
        {
            Random r = new Random();
            List<int> list = Enumerable.Range(0, 10).Select(n => r.Next(1, 10)).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            return list;
        }
        public List<int> Max(List<int> list)
        {
            int max = 0, index = 1;
            List<int> longest = new List<int>();
            while (index < list.Count - 1)
            {
                List<int> current = new List<int>();
                for (int i = index; i < list.Count; i++)
                {
                    if (list[i] % list[i - 1] == 0)
                        current.Add(list[i]);
                    else
                    {
                        index = i + 1;
                        if (max < current.Count)
                        {
                            max = current.Count;
                            longest = current;
                        }
                        break;
                    }
                }
            }
            for (int i = 0; i < longest.Count; i++)
            {
                Console.Write(longest[i] + " ");
            }
            Console.Read();
            return longest;
        }
    }
}

