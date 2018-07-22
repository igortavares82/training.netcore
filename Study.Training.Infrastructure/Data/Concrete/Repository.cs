using Microsoft.EntityFrameworkCore;
using Study.Training.Infrastructure.Data.Context;
using Study.Training.Infrastructure.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Study.Training.Infrastructure.Data.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbContext Context { get; private set; }

        public Repository(DbContext context)
        {
            this.Context = context;
        }

        public void Create(T entity)
        {
            this.Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this.Context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> Read()
        {
            return this.Context.Set<T>().ToList();
        }

        public IEnumerable<T> Read(Func<T, bool> filter)
        {
            return this.Context.Set<T>().Where(filter);
        }

        public void Update(T entity)
        {
            this.Context.Set<T>().Update(entity);
        }
    }
}
