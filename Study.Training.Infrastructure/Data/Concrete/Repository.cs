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
        protected DbContext context = null;

        public Repository(DbContext context)
        {
            this.context = context;
        }

        public void Create(T entity)
        {
            this.context.Set<T>().Add(entity);
            this.context.SaveChanges();
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> Read()
        {
            return this.context.Set<T>().ToList();
        }

        public IEnumerable<T> Read(Func<T, bool> filter)
        {
            return this.context.Set<T>().Where(filter);
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }
    }
}
