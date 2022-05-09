using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 8;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 50;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 4;

            Product[] products = new Product[] { urun1, urun2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.StokAdedi);
                Console.WriteLine("......................");
            }

            Console.WriteLine("........Methods........");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
