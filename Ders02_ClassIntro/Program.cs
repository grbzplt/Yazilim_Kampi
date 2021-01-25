using System;

namespace Ders02_ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Kurs kurs1 = new Kurs();
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.KursunIzlenmeOrani = 68;

            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem Varış";
            kurs2.KursunIzlenmeOrani = 74;

            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay Bilgin";
            kurs3.KursunIzlenmeOrani = 90;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursunEgitmeni = "Murat Kurtboğan";
            kurs4.KursunIzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
            }
        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string KursunEgitmeni { get; set; }
            public int KursunIzlenmeOrani { get; set; }
        }
    }
}
