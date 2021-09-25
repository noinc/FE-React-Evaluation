using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoInc.Models
{
    /// <summary>
    /// Simple entity base class for entities that us a long Id as the primary key
    /// </summary>
    public class EntityBase
    {
        public long Id { get; set; }
    }
}
