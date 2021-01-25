using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void CiktiAl()
        {
            Console.WriteLine("Konut Kredisi verildi...");
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı.");
        }
    }
}
