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
    /// Sql Repository implementation for Interest entities
    /// </summary>
    public class SqlUserRepository : SqlRepositoryBase<User>, IUserRepository
    {
        public SqlUserRepository(NoIncContext context) :base(context)
        {

        }

        public override DbSet<User> DbSet => _context.Users;

        public override IQueryable<User> DbReadSet => DbSet.Include(u => u.Interests).Include(u => u.Skills);
    }
}