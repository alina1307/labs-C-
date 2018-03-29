using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberDigits searcher = new NumberDigits();
            List<int> list = searcher.Input();
            int[] mas = searcher.CountingNumberDigits(list);
            searcher.Output(mas);
        }
    }
}
