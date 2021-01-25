using System;

namespace Ders04_GenericsIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            //Eğer List<> olmasaydı nasıl yapardık?
            Console.WriteLine("-----------MyList-----------");

            MyList<string> isimler = new MyList<string>();

            isimler.Add("Engin");

            Console.WriteLine("-----------------------");
            Console.WriteLine(isimler.Length);
            Console.WriteLine("-----------------------");

            isimler.Add("Murat");
            isimler.Add("Kerem");
            isimler.Add("Halil");

            Console.WriteLine(isimler.Length);
            Console.WriteLine("-----------------------");

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }


            //Eğer Dictionary<> olmasaydı nasıl yapardık?
            Console.WriteLine("-----------MyDictionary-----------");

            MyDictionary<int, string> isimler3 = new MyDictionary<int, string>();

            isimler3.Add(1352, "Engin");
            isimler3.Add(1548, "Murat");
            isimler3.Add(2713, "Kerem");
            isimler3.Add(3573, "Halil");

            Console.WriteLine("-------Count--------");
            Console.WriteLine(isimler3.Length);

            Console.WriteLine("-------Keys---------");
            foreach (var key in isimler3.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("------Values--------");
            foreach (var value in isimler3.Values)
            {
                Console.WriteLine(value);
            }


        }
    }
}
