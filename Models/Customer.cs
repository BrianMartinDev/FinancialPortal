using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    
    public class Customer
    {
        //https://stackoverflow.com/questions/23811912/database-of-bank-accounts
        public long CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Age { get; set; }

        public string PhoneNumber { get; set; }

        //A customer can have many Addresses.
        public IList<Address> Addresses { get; } = new List<Address>(); // Collection navigation

        //A customer can have many Accounts.
        public IList<Account> Accounts { get; } = new List<Account>(); // Collection navigation


    }
}
