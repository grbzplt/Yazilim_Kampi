using Ders05_Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5.Entities
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductUnitPrice { get; set; }

    }
}
