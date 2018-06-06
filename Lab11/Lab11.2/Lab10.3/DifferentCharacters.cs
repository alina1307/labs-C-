using System;
using System.Collections.Generic;

namespace Lab11._2
{
    class DifferentCharacters
    {
        public String Input()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            return str;
        }

        public int SearchDifferentCharacters(String str)
        {
            List<char> found = new List<char>(); //список в котором будут храниться встреченные символы
            int count = 0;
            foreach (char c in str)
                if (found.IndexOf(c) == -1)
                {
                    found.Add(c);
                    count++;
                    Console.Write(c + " ");
                }
            Console.WriteLine();
            return count;
        }

        public void Output (int count)
        {
            Console.WriteLine($"Найдено {count} различных символов");
            Console.ReadKey();
        }
    }
}
