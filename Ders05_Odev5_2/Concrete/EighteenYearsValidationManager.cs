using Ders05_Odev5_2.Abstract;
using Ders05_Odev5_2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5_2.Concrete
{
    public class EighteenYearsValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return gamer.BirthYear < 2000;
        }
    }
}
