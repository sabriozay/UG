using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UG.DAL.Entities
{
    [Table("MUSTERI_FATURA_TABLE")]
    public class CustomerInvoice
    {
        [Key]
        [StringLength(10)]
        public int ID { get; set; }

        [StringLength(10)]
        [Column("MUSTERI_ID")]
        public int CustomerID { get; set; }

        public DateTime FATURA_TARIHI { get; set; }

        public decimal FATURA_TUTARI { get; set; }
        public DateTime ODEME_TARIHI { get; set; }
    }
}
