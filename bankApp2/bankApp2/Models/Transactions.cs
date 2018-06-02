using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bankApp2.Models
{
    public partial class Transactions
    {
        public long Id { get; set; }
        [Column("IBAN")]
        [StringLength(20)]
        public string Iban { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TimeStamp { get; set; }
    }
}
