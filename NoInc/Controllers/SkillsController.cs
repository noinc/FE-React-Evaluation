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
    /// Concrete controller for Interest entities
    /// </summary>
    //[Route("api/skills")]
    //[ApiController]
    public class SkillsController : EntitiesControllerBase<Skill>
    {        
        public SkillsController(ISkillRepository repo) : base(repo, HttpGetRouteName)
        {
        }
        
        [HttpGet("{id}", Name = HttpGetRouteName)]
        public ActionResult<Skill> GetInterestById(long id)
        {
            return GetById(id);
        }

        private const string HttpGetRouteName = "GetSkillById";
    }
}
