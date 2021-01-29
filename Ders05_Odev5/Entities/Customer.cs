using Ders05_Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5.Entities
{
    public class Customer: IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerIdentityKey { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int BirthofYear { get; set; }
        public string TcNo { get; set; }

    }
}
