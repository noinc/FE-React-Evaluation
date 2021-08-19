using Microsoft.AspNetCore.Mvc;
using NoInc.Models;
using NoInc.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoInc.Controllers
{
    /// <summary>
    /// Concrete controller for User entities
    /// </summary>  
    [Route("api/users")]
    [ApiController]
    public class UsersController : EntitiesControllerBase<User>
    {      
        public UsersController(IUserRepository repo) : base(repo, HttpGetRouteName)
        {
        }
        
        [HttpGet("{id}", Name= HttpGetRouteName)]
        public ActionResult<User> GetUserById(long id)
        {
            return GetById(id);
        }

        private const string HttpGetRouteName = "GetUserById";
    }
}
