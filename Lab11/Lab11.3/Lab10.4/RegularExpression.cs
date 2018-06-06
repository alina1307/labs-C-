using System;
using System.Text.RegularExpressions;


namespace Lab11._3
{
    class RegularExpression
    {
        public void FindText(string text, MatchCollection Match)
        {
            for (int i = 0; i < text.Length; i++)
            {
                foreach (Match m in Match)
                {
                    if ((i >= m.Index) && (i < m.Index + m.Length))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.Write(text[i]);
            }
        }
    }
}
