using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoInc.Repositories.Contract
{
    /// <summary>
    /// A repository interface containing basic repository methods
    /// </summary>
    /// <typeparam name="Entity"></typeparam>
    public interface IRepository<Entity>
    {
        /// <summary>
        /// Commits all changes
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();

        /// <summary>
        /// Get all entities
        /// </summary>
        /// <returns></returns>
        IEnumerable<Entity> GetAll();

        /// <summary>
        /// Get the entity with the specified id
        /// </summary>
        Entity Get(long id);

        /// <summary>
        /// Add the specified entity to the data store
        /// </summary>
        void Create(Entity entity);

        /// <summary>
        /// Update the specified entity
        /// </summary>
        /// <returns>true if the entity already exists; false otherwise</returns>
        bool Update(Entity entity);

        /// <summary>
        /// Deletes the specified entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(Entity entity);
    }

}
