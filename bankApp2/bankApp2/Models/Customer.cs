using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bankApp2.Models
{
    public partial class Customer
    {
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Customer(string firstName, string lastName, long? bankId)
        {
            FirstName = firstName;
            LastName = lastName;
            BankId = bankId;
        }

        public Customer(long id, string firstName, string lastName, long? bankId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BankId = bankId;
        }

        public long Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        public long? BankId { get; set; }

        [ForeignKey("BankId")]
        [InverseProperty("Customer")]
        public Bank Bank { get; set; }
    }
}
