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
    /// Concrete controller for Interest entities
    /// </summary>
    [Route("api/interests")]
    [ApiController]
    public class InterestsController : EntitiesControllerBase<Interest>
    {        
        public InterestsController(IInterestRepository repo) : base(repo, HttpGetRouteName)
        {
        }
        
        [HttpGet("{id}", Name = HttpGetRouteName)]
        public ActionResult<Interest> GetInterestById(long id)
        {
            return GetById(id);
        }

        private const string HttpGetRouteName = "GetInterestById";
    }
}
