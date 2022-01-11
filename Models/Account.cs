using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    //An account has an account type.

    public class Account
    {
        public long AccountId { get; set; }

        public int Balance { get; set; }

        public decimal InterestRate { get; set; }

        public long? CustomerId { get; set; }// Foreign key
        public Customer Customer { get; set; } // Reference navigation

        //An account can have many transactions.
        public IList<Transaction> Transactions { get; } = new List<Transaction>(); // Skip collection navigation
    }
}
