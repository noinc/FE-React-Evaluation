using Microsoft.EntityFrameworkCore;
using NoInc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoInc.Data
{
    public class NoIncContext : DbContext
    {
        public NoIncContext(DbContextOptions<NoIncContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Interest> Interests { get; set; }

        public DbSet<Skill> Skills { get; set; }
    }
}
