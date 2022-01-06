using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialPortal.Repository;
using Microsoft.EntityFrameworkCore;

namespace FinancialPortal.Data
{
    public class Repository<ApplicationDbContext> : IRepository where ApplicationDbContext : DbContext
    {

        protected ApplicationDbContext dbContext;

        public Repository(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public async Task CreateAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Add(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Remove(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }
        public async Task<List<T>> SelectAll<T>() where T : class
        {
            return await this.dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> SelectById<T>(long id) where T : class
        {
            return await this.dbContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Update(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }
    }
}
