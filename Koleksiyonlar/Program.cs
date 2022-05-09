using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[] { "Engin", "Murat", "Enes", "Halil" };
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);
            Console.WriteLine(name[3]);
            Console.WriteLine("..................");

            List<string> name2 = new List<string> { "Engin", "Murat", "Enes", "Halil" };
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);
            Console.WriteLine(name[3]);

            name2.Add("İlker");
            Console.WriteLine(name2[4]);
            Console.WriteLine(name2[0]);
        }
    }
}
