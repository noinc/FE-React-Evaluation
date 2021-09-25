using Microsoft.EntityFrameworkCore;
using NoInc.Data;
using NoInc.Models;
using NoInc.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoInc.Repositories.Sql
{
    /// <summary>
    /// Handles sql server transactions
    /// </summary>
    /// <typeparam name="Entity"></typeparam>
    public abstract class SqlRepositoryBase<Entity> : IRepository<Entity>
        where Entity : EntityBase
    {
        /// <summary>
        /// The DB Conetext
        /// </summary>
        protected readonly NoIncContext _context;

        /// <summary>
        /// Constructor for dependency injection
        /// </summary>
        /// <param name="context"></param>
        public SqlRepositoryBase(NoIncContext context)
        {
            _context = context;
        }

        /// <summary>
        /// The concrete classes must provide the DbSet that contains all of the entities
        /// </summary>
        public abstract DbSet<Entity> DbSet { get; }

        /// <summary>
        /// For entities with children, they can override this method to ensure that 
        /// child data is retrieved along with parent data
        /// </summary>
        public virtual IQueryable<Entity> DbReadSet => DbSet;

        /// <summary>
        /// Adds the specified entity to the DB
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Create(Entity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            DbSet.Add(entity);
        }

        /// <summary>
        /// Deletes the specified entity from the DB
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(Entity entity)
        {
            DbSet.Remove(entity);
        }

        /// <summary>
        /// Retrieves the entity that has a primary key matching the specified id
        /// </summary>
        public virtual Entity Get(long id)
        {
            return DbReadSet.FirstOrDefault(e => e.Id == id);
        }

        /// <summary>
        /// Retrieves all entities
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<Entity> GetAll()
        {
            return DbReadSet.ToList();
        }

        /// <summary>
        /// Commits all unsaved changes
        /// </summary>
        /// <returns></returns>
        public virtual bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        /// <summary>
        /// Updates an existing entity
        /// </summary>
        /// <param name="entity">The updated entity</param>
        /// <returns>true if the entity already exists; false otherwise</returns>
        public virtual bool Update(Entity entity)
        {
            var existing = DbSet.AsNoTracking().FirstOrDefault(e => e.Id == entity.Id);
            if (existing == null)
            {
                return false;
            }
            _context.Update(entity);
            return true;
        }
    }
}
