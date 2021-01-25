using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_OOP3
{
    class BasvuruManager
    {
        //Console.WriteLine("****************************************************");
        //public void BasvuruYap()
        //{
        //    //Aş yöntemle BasvuruYap() metodu sadece KonutKrediManager a bağlı kalmış olur.
        //    //Halbuki diğer KrediManager ları da kullanmalıyız.Bu doğru çözüm değil.

        //    KonutKrediManager konutKrediManager = new KonutKrediManager();
        //    konutKrediManager.Hesapla();
        //}

        //Console.WriteLine("**************************2*************************");

        //IKrediManager referansıyla her üçünün referansını tutabiliriz.
        //Method injection
        public void BasvuruYap(IKrediManager krediManager)
        {
            krediManager.Hesapla();
        }

        //Console.WriteLine("**************************3**************************");

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        //Console.WriteLine("-----------------------5- Logger--------------------------");
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {

            krediManager.Hesapla();

            loggerService.Log();

        }

        //Console.WriteLine("-----------------------6- Loggers--------------------------");
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {

            krediManager.Hesapla();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }




    }
}
