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
    /// Sql Repository implementation for Skill entities
    /// </summary>
    public class SqlSkillRepository : SqlRepositoryBase<Skill>, ISkillRepository
    {
        public SqlSkillRepository(NoIncContext context) : base(context)
        {

        }

        public override DbSet<Skill> DbSet => _context.Skills;
    }
}
