using Microsoft.EntityFrameworkCore;
using MVC.BLL.Interfaces;
using MVC.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MVCAppDbContext context;

        public GenericRepository(MVCAppDbContext context)
        {
            this.context = context;
        }
        public async Task<int> Add(T obj)
        {
            await this.context.Set<T>().AddAsync(obj);
            return await this.context.SaveChangesAsync();
        }

        public async Task<int> Delete(T obj)
        {
            this.context.Set<T>().Remove(obj);
            return await this.context.SaveChangesAsync();
        }

        public async Task<T> Get(int? id)
        => await this.context.Set<T>().FindAsync(id);

        public async Task<IEnumerable<T>> GetAll()
            => await this.context.Set<T>().ToListAsync();

        public async Task<int> Update(T obj)
        {
            this.context.Set<T>().Update(obj);
            return await this.context.SaveChangesAsync();
        }
    }
}
