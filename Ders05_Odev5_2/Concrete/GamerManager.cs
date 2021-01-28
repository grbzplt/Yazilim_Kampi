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
        //Sınıf içinde sınıfı new leme onun yerine aş. gibi yap.
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
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
