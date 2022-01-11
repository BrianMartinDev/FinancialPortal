using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    public class AccountType
    {
        public long AccountTypeId { get; set; }

        public string Name { get; set; }
    }
}
