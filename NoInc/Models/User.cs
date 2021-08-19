using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoInc.Models
{
    /// <summary>
    /// Represents a User of teh system
    /// </summary>
    public class User : EntityBase
    {
        /// <summary>
        /// The user's age
        /// </summary>
         public int Age { get; set; }

        /// <summary>
        /// The userr's interests
        /// </summary>
        public List<Interest> Interests { get; set; } = new List<Interest>();

        /// <summary>
        /// The userr's skills
        /// </summary>
        public List<Skill> Skills { get; set; } = new List<Skill>();
    }
}
