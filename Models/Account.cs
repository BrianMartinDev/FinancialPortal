using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace FinancialPortal.Models
{
    //An account has an account type.

    public class Account
    {
        [Key]
        public long AccountId { get; set; }

        public int Balance { get; set; }

        public decimal InterestRate { get; set; }


        public AccountType AccountType { get; set; }

        [ForeignKey("AccountType")]
        public long AccountTypeFKId { get; set; }


    }
}
