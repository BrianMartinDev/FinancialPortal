using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    //An account can have many transactions.
    //A transaction is posted to one account.
    public class Transaction
    {
        public long TransactionId { get; set; }

        public long TransationAmount { get; set; }

        public int? AccountId { get; set; } // Foreign key
        public Account Account { get; set; } // Reference navigation



    }
}
