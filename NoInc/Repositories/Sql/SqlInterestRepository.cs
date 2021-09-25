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
    public class SqlInterestRepository : SqlRepositoryBase<Interest>, IInterestRepository
    {
        public SqlInterestRepository(NoIncContext context) : base(context)
        {

        }

        public override DbSet<Interest> DbSet => _context.Interests;
    }
}
