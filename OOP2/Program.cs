using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual individual1 = new Individual();
            individual1.Id = 1;
            individual1.CustomerNumber = "123";
            individual1.Name = "Enes";
            individual1.Surname = "Altınorak";
            individual1.PublicId = "12345678901";


            Corporate corporate1 = new Corporate();
            corporate1.Id = 2;
            corporate1.CustomerNumber = "1234";
            corporate1.CompanyName = "Ecole42";
            corporate1.TaxNumber = "1234567890";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individual1);
            customerManager.Add(corporate1);
        }
    }
}
