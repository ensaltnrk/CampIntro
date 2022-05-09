using System;

namespace DegerVeReferansType
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 15;
            int sayi2 = 20;
            
            sayi1 = sayi2;
            sayi2 = 35;

            Console.WriteLine(sayi1);//20

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 110, 220, 330 };

            sayilar1 = sayilar2;
            sayilar2[0] = 70;
            Console.WriteLine(sayilar1[0]);//70
        }
    }
}
