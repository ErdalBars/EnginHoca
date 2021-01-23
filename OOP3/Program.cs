using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new DatabaseLoggerService();

          

            basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager, tasitKrediManager, konutKrediManager
            };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
//İnterface leri birbirinin alternatifi...