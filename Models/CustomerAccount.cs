using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    // An account can have many customers.
    public class CustomerAccount
    {
        public long CustomerAccountId { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("Customer")]
        public long CustomerFKId { get; set; }

        public Account Account { get; set; }

        [ForeignKey("Account")]
        public long AccountFKId { get; set; }


    }
}
