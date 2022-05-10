using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager mortgageManager = new MortgageManager();
            ICrediManager vehicleManager = new VehicleManager();
            ICrediManager consumerManager = new ConsumerManager();
            ICrediManager esnafCrediManager = new EsnafCrediManager();

            ILoggerService loggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService(), new DatabaseLoggerService()};


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuru(consumerManager, loggers);
            //basvuruManager.Basvuru(esnafCrediManager, loggers);


            List<ICrediManager> credis = new List<ICrediManager>() {consumerManager, vehicleManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(credis);
        }
    }
}
