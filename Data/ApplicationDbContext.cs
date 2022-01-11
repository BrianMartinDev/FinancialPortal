using FinancialPortal.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialPortal.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //// Account Table
            //modelBuilder.Entity<Account>()
            //    .HasOne<AccountType>(e => e.AccountType)
            //    .WithOne(e => e.AccountTypeId\).IsRequired(true)
            //    .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Country>()
            //.HasOne(a => a.CapitalCity)
            //.WithOne(a => a.Country)
            //.HasForeignKey<CapitalCity>(c => c.CountryID);

            //// AccountType Table
            //modelBuilder.Entity<AccountType>()
            //    .HasOne<Account>(s => s.Account)
            //    .WithOne(g => g.AccountType)
            //    .IsRequired(true)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// Address Table
            //modelBuilder.Entity<Address>()
            //    .HasOne<Customer>(s => s.Customer)
            //    .WithMany(g => g.Address)
            //    .HasForeignKey(s => s.AddressId)
            //    .IsRequired(true)
            //    .OnDelete(DeleteBehavior.Cascade); ;

            //// Customer Table
            //modelBuilder.Entity<Customer>()
            //    .HasMany<Address>(e => e.Address)
            //    .WithOne(x => x.Customer)
            //    .IsRequired(true)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// CustomerAccount Table
            //modelBuilder.Entity<CustomerAccount>()
            //    .HasOne<Customer>(e => e.Customer)
            //    .WithOne(e => e.CustomerAccount)
            //    .IsRequired(true)
            //    .OnDelete(DeleteBehavior.Cascade);

            //// CustomerAccount Table
            //modelBuilder.Entity<CustomerAccount>()
            //    .HasMany<Account>(e => e.Account)
            //    .WithOne(e => e.CustomerAccount)
            //    .IsRequired(true)
            //    .OnDelete(DeleteBehavior.Cascade);
 
 
 

            base.OnModelCreating(modelBuilder);

        }
    }
}
