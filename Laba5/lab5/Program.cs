using System;
using System.Collections.Generic;
using System.Linq;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<int> list = Enumerable.Range(0, 10).Select(n => r.Next(1, 10)).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Max searcher = new Max();
            List<int> result = searcher.SearchTheMaximum(list);
            searcher.Output(result);
        }
    }
}
