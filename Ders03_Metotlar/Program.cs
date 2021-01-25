using System;

namespace Ders03_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            urun3.Adi = "Armut";
            urun3.Fiyati = 45;
            urun3.Aciklama = "Ankara armutu";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
            }

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun3);
        }
    }
}
