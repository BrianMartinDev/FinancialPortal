using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    //A customer can have many accounts.
    public class Customer
    {
        //https://stackoverflow.com/questions/23811912/database-of-bank-accounts
        [Key]
        public long CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public Address Address { get; set; }

        [ForeignKey("Address")]
        public long AddressFKId { get; set; }

    }
}
