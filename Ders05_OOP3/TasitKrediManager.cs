using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_OOP3
{
    class TasitKrediManager : IKrediManager
    {
        public void CiktiAl()
        {
            Console.WriteLine("Taşit Kredisi verildi...");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi ödeme planı hesaplandı.");
        }
    }
}
