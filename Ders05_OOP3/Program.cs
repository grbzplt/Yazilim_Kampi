using System;
using System.Collections.Generic;

namespace Ders05_OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Düzenleme
            //Aş üç farklı KrediManager referansı, IKrediManager referansı tarafından tutulabildi.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            Console.WriteLine("------------------------ -1- --------------------------");
            ihtiyacKrediManager.Hesapla();
            tasitKrediManager.Hesapla();
            konutKrediManager.Hesapla();


            BasvuruManager basvuruManager = new BasvuruManager();
            Console.WriteLine("");
            Console.WriteLine("---------------- -2- Method injection --------------------");

            //Aş gibi istediğimiz KrediManager ı gönderebiliriz ve onun Hesapla() metodu çalışır.

            basvuruManager.BasvuruYap(new IhtiyacKrediManager());
            basvuruManager.BasvuruYap(new TasitKrediManager());
            basvuruManager.BasvuruYap(new KonutKrediManager());

            Console.WriteLine("");
            Console.WriteLine("----------------- -3- List<> Tek Kredi -------------------");

            List<IKrediManager> krediler1 = new List<IKrediManager>() { ihtiyacKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler1);

            Console.WriteLine("");
            Console.WriteLine("------------------4- List<> Çoklu Kredi ------------------");

            List<IKrediManager> krediler2 = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler2);


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            Console.WriteLine("");
            Console.WriteLine("-----------------------5- Logger--------------------------");

            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);

            Console.WriteLine("-----------------------5a- Logger--------------------------");

            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);

            Console.WriteLine("-----------------------5b- Logger--------------------------");

            basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

            //EsnafKredisiManager hiçbir koda dokunmadan eklendi.
            Console.WriteLine("-----------------------5c- Logger--------------------------");

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), fileLoggerService);

            // SmsLoggerService hiçbir koda dokunmadan eklendi.
            Console.WriteLine("-----------------------5d- Logger--------------------------");

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());


            Console.WriteLine("");
            Console.WriteLine("-----------------------6- Loggers--------------------------");

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

        }
    }
}
