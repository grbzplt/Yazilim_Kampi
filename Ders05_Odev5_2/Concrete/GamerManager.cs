using Ders05_Odev5_2.Abstract;
using Ders05_Odev5_2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5_2.Concrete
{
    //MicroService
    public class GamerManager : IGamerService
    {
        
        IUserValidationService[] validators;

        public GamerManager(params IUserValidationService[] validators)
        {
            this.validators = validators ?? throw new ArgumentNullException(nameof(validators));
        }    

        public void Add(Gamer gamer)
        {
            var result = true;

            foreach (var validator in validators)
            {
                result = result && validator.Validate(gamer);
            }

            if (result)
            {
                Console.WriteLine("{0} {1} Kayıt oldu...",gamer.FirstName,gamer.LastName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
