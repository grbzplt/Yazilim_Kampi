using Ders05_Odev5.Abstract;
using Ders05_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5.Concrete
{
    public class CustomerTcNoControlService:Customer
    {
        public CustomerTcNoControlService(Customer customer)
        {
            TcNoControl(customer);
        }
        public bool TcNoControl(Customer customer)
        {
            if (customer.CustomerFirstName=="Gürbüz" && customer.CustomerLastName == "Polat" && customer.BirthofYear == 1959 && customer.TcNo == "12345678900")
            {
                Console.WriteLine("Müşteri kimlik bilgileri doğrudur...");
                return true;
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!!! Lütfen kimlik bilgilerinizi kontrol ediniz");
                return false;
            }
        }
    }
}
