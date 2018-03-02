using ConsoleApp2;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ArraySorting searcher = new ArraySorting();
        List<int> list = searcher.Input();
        searcher.Max(list);
    }
}