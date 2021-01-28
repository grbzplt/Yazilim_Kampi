using Ders05_Odev5_2.Abstract;
using Ders05_Odev5_2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5_2.Concrete
{
    public class FirstUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "ENGİN"
                && gamer.LastName == "DEMİROĞ" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
