using System;

namespace Lab11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DifferentCharacters searcher = new DifferentCharacters();
            String str = searcher.Input();
            int count = searcher.SearchDifferentCharacters(str);
            searcher.Output(count);
            Console.ReadKey();
        }
    }
}

