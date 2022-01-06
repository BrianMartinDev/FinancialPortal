using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    public class Address
    {
        [Key]
        [JsonProperty("addressID")]
        public int AddressID { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
         
    }
}