using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] curses = new string[] { "Java", "Python", "SQL", "C++", "C", "C#", "Rust"};
            
            for (int i = 0; i < curses.Length; i++)
            {
                Console.WriteLine(curses[i]);
            }

            Console.WriteLine("For bitti");
            foreach (string curs in curses)
            {
                Console.WriteLine(curs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
