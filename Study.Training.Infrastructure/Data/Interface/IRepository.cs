using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Training.Infrastructure.Data.Interface
{
    public interface IRepository<T> where T : class
    {
        DbContext Context { get; }

        /// <summary>
        /// Creates an entity of type 'T'
        /// </summary>
        /// <param name="entity">entity to be added</param>
        void Create(T entity);

        /// <summary>
        /// Reads all entities of type 'T'
        /// </summary>
        /// <returns>enumerable of type 'T'</returns>
        IEnumerable<T> Read();

        /// <summary>
        /// Reads all entities of type 'T' within criteria
        /// </summary>
        /// <param name="filter">criteria of selction</param>
        /// <returns>enumerable of type 'T'</returns>
        IEnumerable<T> Read(Func<T, bool> filter);

        /// <summary>
        /// Updates an entity of type 'T'
        /// </summary>
        /// <param name="entity">the entity to be updated</param>
        void Update(T entity);

        /// <summary>
        /// Deletes an entity of type 'T'
        /// </summary>
        /// <param name="entity">the entity to be deleted</param>
        void Delete(T entity);
    }
}
