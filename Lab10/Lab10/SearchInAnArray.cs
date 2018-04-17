using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab10
{
    class SearchInAnArray
    {
        public List<int> Input()
        {
            string fileName = "Input.txt";
            StreamReader streamReader = File.OpenText(fileName);
            List<int> list = new List<int>();

            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                list.Add(Convert.ToInt32(line));
            }
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

            string destFilename = "Output.txt";
            using (StreamWriter writer = File.CreateText(destFilename)) 
            {
                for (int i = 0; i < longest.Count; i++)
                {
                    Console.Write(longest[i] + " ");
                    writer.Write(longest[i] + " ");
                }
            }
            Console.Read();
            return longest;
        }
    }
}
