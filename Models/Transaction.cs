using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    //An account can have many transactions.
    //A transaction is posted to one account.
    public class Transaction
    {
        [Key]
        public long TransactionId { get; set; }


        public long TransationAmount { get; set; }

        public Account Account { get; set; }

        [ForeignKey("Account")]
        public long AccountFKId { get; set; }
    }
}
