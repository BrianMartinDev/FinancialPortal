using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    public class AccountType
    {
        [Key]
        public long AccountTypeId { get; set; }
        // needs enums
        public string AccountTypeName { get; set; }

    }
}
