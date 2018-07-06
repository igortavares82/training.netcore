using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Infrastructure.Data.Interface
{
    public interface IRepository<T>
    {
        void Create(T entity);
        IEnumerable<T> Read();
        void Update(T entity);
        void Delete(T entity);
    }
}
