using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    // An account can have many customers.
    public class CustomerAccount
    {
        public long CustomerAccountId { get; set; }


    }
}
