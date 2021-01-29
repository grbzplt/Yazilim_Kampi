using Ders05_Odev5_2.Abstract;
using Ders05_Odev5_2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5_2.Concrete
{
    public class IsLastNameEmptyValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return !string.IsNullOrEmpty(gamer.LastName);
        }
    }
}
