using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6
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
      
            LongString searcher = new LongString();
            List<int> result= searcher.DeleteLongestSeries(list);
            searcher.Output(result);
        }
    }
}
