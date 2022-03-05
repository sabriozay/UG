using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UG.DAL.Entities
{
    [Table("MUSTERI_TANIM_TABLE")]
    public class Customer
    {
        [Key]
        [StringLength(10), Column(TypeName = "int")]
        public int ID { get; set; }
        [StringLength(255), Column(TypeName = "varchar(255)")]
        public string? UNVAN { get; set; }


        public ICollection<CustomerInvoice>? CustomerInvoices { get; set; }
    }
}
