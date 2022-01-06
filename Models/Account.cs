using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    //An account has an account type.

    public class Account
    {
        [Key]
        [JsonProperty("accountID")]
        public int AccountID { get; set; }

        [JsonProperty("balance")]
        public int Balance { get; set; }

        [JsonProperty("interestRate")]
        public decimal dec { get; set; }
        //typo
        [JsonProperty("phoneNumber")]
        public string LastaAccessTimeStamp { get; set; }

        [JsonProperty("accountType")]
        public AccountType AccountType { get; set; }


    }
}
