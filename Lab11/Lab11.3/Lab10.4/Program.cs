using System;
using System.Text.RegularExpressions;

namespace Lab11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"
            <html> Указывает программе просмотра страниц, что это HTML документ.
            <h1>Создает самый большой заголовок (как отдельный абзац).
            <table> Создает таблицу.
            <form> Создает формы";

            string RegExpression = @"\<html\>|\<h1\>|\<form\>";
            MatchCollection match = Regex.Matches(text, RegExpression);

            RegularExpression searcher = new RegularExpression();
            searcher.FindText(text, match);
            Console.ReadLine();
        }
    }
}

