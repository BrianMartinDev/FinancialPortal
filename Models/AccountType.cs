using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    public class AccountType
    {
        [Key]
        [JsonProperty("accountTypeID")]
        public int AccountTypeID { get; set; }
        // needs enums
        [JsonProperty("accountTypeName")]
        public string AccountTypeName { get; set; }
    }
}
