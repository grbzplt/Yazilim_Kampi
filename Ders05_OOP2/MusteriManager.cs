using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_OOP2
{
    //iş sınıfları
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            if (musteri.Id == 1)
            {
                Console.WriteLine("Müşteri1 eklendi");
            }
            if (musteri.Id == 2)
            {
                Console.WriteLine("Müşteri2 eklendi");
            }

            Console.WriteLine("Müşteri eklendi");

        }
    }
}
