using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5_3
{
    public class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
