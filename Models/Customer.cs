using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    //A customer can have many accounts.
    public class Customer
    {
            //https://stackoverflow.com/questions/23811912/database-of-bank-accounts
            [Key]
            [JsonProperty("customerID")]
            public int CustomerID { get; set; }

            [JsonProperty("firstName")]
            public string FirstName { get; set; }

            [JsonProperty("lastName")]
            public string LastName { get; set; }

            [JsonProperty("age")]
            public int Age { get; set; }

            [JsonProperty("phoneNumber")]
            public string PhoneNumber { get; set; }

            [JsonProperty("address")]
            public Address Address { get; set; }
        
    }
}
