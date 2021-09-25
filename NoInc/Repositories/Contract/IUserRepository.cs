using NoInc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoInc.Repositories.Contract
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUsernameAndPassword(string username, string password);
    }
}
