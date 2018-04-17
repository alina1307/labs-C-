using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            SearchInAnArray searcher = new SearchInAnArray();
            List<int> list = searcher.Input();
            searcher.Max(list);
            Console.ReadKey();
        }
    }
}
