using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoInc.Models;
using NoInc.Repositories.Contract;
using NoInc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoInc.Controllers
{
    /// <summary>
    /// Concrete controller for User entities
    /// </summary>  
    //[Route("api/users")]
    //[ApiController]
    public class UsersController : EntitiesControllerBase<User>
    {      
        public UsersController(IJwtAuthenticationManager authManager, IUserRepository repo) :
            base(repo, HttpGetRouteName)
        {
            _authManager = authManager;
        }
        
        [HttpGet("{id}", Name= HttpGetRouteName)]
        public ActionResult<User> GetUserById(long id)
        {
            return GetById(id);
        }

        /// <summary>
        /// Allow users to be created without logging in
        /// </summary>
        [HttpPost]
        [AllowAnonymous]
        public override ActionResult<User> Create(User user)
        {
            return base.Create(user);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate(UserCredentials userCredentials)
        {
            if (!IsAuthenticatedUser(userCredentials))
                return Unauthorized();

            var token = _authManager.CreateAuthenticationToken(userCredentials.Username);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }


        private bool IsAuthenticatedUser(UserCredentials userCredentials)
        {
            return ((IUserRepository)_repo)
                .GetByUsernameAndPassword(userCredentials.Username, userCredentials.Password) != null;
        }

        private readonly IJwtAuthenticationManager _authManager;
        private const string HttpGetRouteName = "GetUserById";
    }
}
