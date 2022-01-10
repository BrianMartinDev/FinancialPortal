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

            modelBuilder.Entity<CustomerAccount>()
                .HasOne<Customer>(e => e.Customer).WithOne().IsRequired(true).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CustomerAccount>()
                .HasOne<Account>(e => e.Account).WithOne().IsRequired(true).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Customer>()
                .HasOne<Address>(e => e.Address).WithOne().IsRequired(true).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Account>()
                .HasOne<AccountType>(e => e.AccountType).WithOne().IsRequired(true).OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);

        }
    }
}
