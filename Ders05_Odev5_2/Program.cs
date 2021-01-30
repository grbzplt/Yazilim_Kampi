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

            GamerManager gamerManager1 = new GamerManager(new EighteenYearsValidationManager());
            gamerManager1.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "",
                IdentityNumber = 12345
            });

            GamerManager gamerManager2 = new GamerManager(new EighteenYearsValidationManager(), new IsLastNameEmptyValidationManager());
            gamerManager2.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "",
                IdentityNumber = 12345
            });

            Console.ReadLine();
        }
    }
}
