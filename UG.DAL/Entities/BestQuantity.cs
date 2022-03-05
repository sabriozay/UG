using System;
using System.Collections.Generic;
using System.Text;

namespace UG.DAL.Entities
{
    public class BestQuantity:CustomerInvoice
    {

        public Decimal quantity { get; set; }
        public int MUSTERI_ID { get; set; }
    }
}
