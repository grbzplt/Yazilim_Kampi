using Ders05_Odev5_2.Concrete;
using Ders05_Odev5_2.Entities;
using Ders05_Odev5_2.Abstract;
using System;

namespace Ders05_Odev5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------FirstUserValidationManager---------------------");
            GamerManager gamerManager1 = new GamerManager(new FirstUserValidationManager());
            gamerManager1.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            });

            Console.WriteLine("----------------SecondUserValidationManager--------------------");
            GamerManager gamerManager2 = new GamerManager(new SecondUserValidationManager());
            gamerManager2.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1984,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            });



        }
    }
}
