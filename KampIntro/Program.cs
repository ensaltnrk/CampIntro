using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int studentSayısı = 122;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            bool sistemeGirisYapmismi = true;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Yüseliş butonu");
            }
            else
                Console.WriteLine("Değişmedi butonu");

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
                Console.WriteLine("Giriş yap butonu");
        }
    }
}
