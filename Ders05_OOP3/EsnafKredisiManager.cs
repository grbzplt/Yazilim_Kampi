using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_OOP3
{
    class EsnafKredisiManager : IKrediManager
    {
        public void CiktiAl()
        {
            Console.WriteLine("Esnaf Kredisi verildi...");
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }
    }
}
