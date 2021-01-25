using System;

namespace Ders02_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java kursu";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine("---Sayfa Sonu---");

            Console.WriteLine("---------------------------------------------------------");

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java kursu", "Python kursu" };

            for (int kurs = 0; kurs < kurslar.Length; kurs++)
            {
                Console.WriteLine(kurslar[kurs]);
            }
            Console.WriteLine("---Sayfa Sonu---");

            Console.WriteLine("---------------------------------------------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("---Sayfa Sonu---");
        }
    }
}
