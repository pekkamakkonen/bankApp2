using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bankApp2.Models
{
    public partial class Bank
    {
        public Bank()
        {
            Customer = new HashSet<Customer>();
        }

        public long Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("BIC")]
        [StringLength(10)]
        public string Bic { get; set; }

        [InverseProperty("Bank")]
        public ICollection<Customer> Customer { get; set; }
    }
}
