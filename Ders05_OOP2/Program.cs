using System;

namespace Ders05_OOP2
{
    class Program
    {
        //Gerçek Müşteri - Tüzel Müşteri
        //SOLID --> L
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "456321";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123456789";

            //Hem GercekMusteri nin hem de TuzelMusteri nin referansını Musteri referansında tutabildik.
            //Çünkü herikisi de Musteri den kalıtım aldı.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //MusteriManager de  Ekle metodu, Ekle(Musteri musteri)  şeklinde tanımlandı.
            //Yani tüm Musteri referanslarını bu metoda yollayabiliriz.

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("-------------1------------");
            musteriManager.Ekle(musteri1);

            Console.WriteLine("-------------2------------");
            musteriManager.Ekle(musteri2);

            Console.WriteLine("-------------3------------");
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
