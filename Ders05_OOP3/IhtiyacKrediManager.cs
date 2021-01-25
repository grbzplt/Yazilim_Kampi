using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void CiktiAl()
        {
            Console.WriteLine("İhtiyaç Kredisi verildi...");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi ödeme planı hesaplandı.");
        }
    }
}
