using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    public class Address
    {
        [Key]
        public long AddressId { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }
         
    }
}