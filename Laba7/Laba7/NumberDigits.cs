using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class NumberDigits
    {
        public List<int> Input ()
        {
            Random r = new Random();
            List<int> list = Enumerable.Range(0, 15).Select(n => r.Next(1, 10)).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            return list;
        }

        public int[] CountingNumberDigits(List<int> list)
        {
            int[] counter = new int[10];
            int kol = list.Count();
            Console.Write("Количество цифр в массиве = " + kol + "\n");
            for (int i = 0; i < list.Count; i++)
            {
                counter[list[i]]++;
            }
            return counter;
        }

        public void Output (int[] counter)
        {
            for (int i = 0; i < counter.Length; i++)
            {
                Console.Write(" Количество " + i + " = " + counter[i] + "\n");
            }
            Console.Read();
        }
    }
}
