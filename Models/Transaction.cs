using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    //An account can have many transactions.
    //A transaction is posted to one account.
    public class Transaction
    {
        [Key]
        [JsonProperty("customerAccountCreationTimeStamp")]
        public long TransactionID { get; set; }

        [JsonProperty("customerAccountCreationTimeStamp")]
        public string TransactionTimeStamp { get; set; }

        [JsonProperty("customerAccountCreationTimeStamp")]
        public long TransationAmount { get; set; }

        [JsonProperty("customerAccountCreationTimeStamp")]
        public Account Account { get; set; }
    }
}
