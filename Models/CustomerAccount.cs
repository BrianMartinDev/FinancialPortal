using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    // An account can have many customers.
    public class CustomerAccount
    {
        [Key]
        [JsonProperty("CustomerAccountID")]
        public int CustomerAccountID { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("customerAccountCreationTimeStamp")]
        public string CustomerAccountCreationTimeStamp { get; set; }
    }
}
