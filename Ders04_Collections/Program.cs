using System;
using System.Collections.Generic;

namespace Ders04_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Dizi----------");
            string[] isimler = new string[]     //isimler={"Engin","Murat","Kerem","Halil"}
            {
                "Engin",
                "Murat",
                "Kerem",
                "Halil"
            };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            Console.WriteLine("------------");
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);    //HATA  çünkü dizi eleman sayısını aştık.

            //Belki şu yol aklımız gelir fakat bu yolda istediğimizi vermez.
            isimler = new string[5];    //new ile stack de yeni bir alan açmış olduk.
            isimler[4] = "İlker";       //isimler={null,null,null,null,"ilker"}
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            //List<string> isimler2 = new List<string>();   //1.yol ile doldurulabilir.
            //isimler2.Add("Engin");
            //isimler2.Add("Murat");
            //isimler2.Add("Kerem");
            //isimler2.Add("Halil");

            Console.WriteLine("-----------List-----------");
            List<string> isimler2 = new List<string>        //2.yol ile doldurma daha kolay
            {
                "Engin",
                "Murat",
                "Kerem",
                "Halil"
            };

            isimler2.Add("İlker");  //Aynı senaryoyu burada uygularsak hiçbir sorun olmaz.

            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);


            //Şimdi soru şu: Eğer List<> olmasaydı bunları nasıl yapardık? Cevap --> Ders4_GenericsIntro

            Console.WriteLine("-----------Dictionary-----------");

            //Dictionary sınıfı eklendiği elemanları key ve value olarak kaydetme imkanı veren bir yapıdır.

            Dictionary<int, string> isimler3 = new Dictionary<int, string>();

            isimler3.Add(1352, "Engin");
            isimler3.Add(1548, "Murat");
            isimler3.Add(2713, "Kerem");
            isimler3.Add(3573, "Halil");

            //Yazdırma işlemi biraz farklıdır.

            foreach (KeyValuePair<int, string> isim in isimler3)
            {
                Console.WriteLine("ID = {0}, Ad = {1}", isim.Key, isim.Value);
            }

            //Burada dikkat edilecek şey key 'in benzersiz olmasıdır.Aynı değerler gelirse hata verir.

        }
    }
}
