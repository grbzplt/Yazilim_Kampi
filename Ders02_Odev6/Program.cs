using System;

namespace Ders02_Odev6
{
    class Program
    {
        class Program
        {
            static void Main(string[] args)
            {
                var urunler = new Bilgisayar[]
                {
                new Bilgisayar()
                {
                    BilgisayarAdi = "Casper Excalibur G900",
                    BilgisayarTuru= "Dizüstü bilgisayar",
                    BilgisayarFiyati = 11499,
                    StokdaVarmi = true
                },
                new Bilgisayar()
                {
                    BilgisayarAdi = "HP 340S G7",
                    BilgisayarTuru= "Dizüstü bilgisayar",
                    BilgisayarFiyati = 5540,
                    StokdaVarmi = true
                },
                new Bilgisayar()
                {
                    BilgisayarAdi = "Acer Nitro N50-610",
                    BilgisayarTuru= "Masaüstü bilgisayar",
                    BilgisayarFiyati = 11499,
                    StokdaVarmi = true
                },
                new Bilgisayar()
                {
                    BilgisayarAdi = "MSI Cubi 5 10M-061EU",
                    BilgisayarTuru= "Mini Masaüstü bilgisayar",
                    BilgisayarFiyati = 11499,
                    StokdaVarmi = false
                }
                };

                Console.WriteLine("");
                Console.WriteLine("---------------- FOREACH ------------------");

                foreach (var urun in urunler)
                {
                    Console.WriteLine(urun);
                }



                Console.WriteLine("");
                Console.WriteLine("---------------- FOR ------------------");

                for (int urun = 0; urun < urunler.Length; urun++)
                {
                    Console.WriteLine(urunler[urun]);
                }
                Console.WriteLine("");
                Console.WriteLine("---------------- WHİLE ------------------");

                int index = 0;
                while (index < urunler.Length)
                {
                    Console.WriteLine(urunler[index]);
                    index++;
                }

                Console.ReadLine();
            }

            public class Bilgisayar
            {
                public string BilgisayarAdi { get; set; }
                public string BilgisayarTuru { get; set; }
                public int BilgisayarFiyati { get; set; }
                public bool StokdaVarmi { get; set; }

                public override string ToString()
                {
                    return $"{BilgisayarAdi} - {BilgisayarTuru} - {BilgisayarFiyati} TL - {(StokdaVarmi ? "Stokda var" : "Stokda yok")}";
                }
            }
        }
    }
}
