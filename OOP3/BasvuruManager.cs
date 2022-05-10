using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        public void Basvuru(ICrediManager crediManager, List<ILoggerService> loggerServices)
        {
            crediManager.Calculater();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICrediManager> credis)
        {
            foreach (var credi in credis)
            {
                credi.Calculater();
            }
        }
    }
}
