using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UG.DAL.Entities
{
    public class MUSTERI_TANIM_TABLE
    {
        [Key]
        [StringLength(10), Column(TypeName = "int")]
        public int ID { get; set; }
        [StringLength(255), Column(TypeName = "varchar(255)")]
        public string? UNVAN { get; set; }
    }
}
