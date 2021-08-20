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
    /// Base controller class for entities with a primary Id field. 
    /// This class takes care of get, post, put{id}, and delete{id} requests,
    /// However, for technical reasons, concrete classes must implement their own get{id}
    /// method, providing the route name with the constructor, although
    /// they can delegate the method implementation to the GetById method
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public abstract class EntitiesControllerBase<Entity> : ControllerBase
        where Entity : EntityBase
    {
        public EntitiesControllerBase(IRepository<Entity> repo, string httpGetRouteName)
        {
            _repo = repo;
            _httpGetRouteName = httpGetRouteName;
        }

        protected readonly IRepository<Entity> _repo;
        private readonly string _httpGetRouteName;

        [HttpGet]        
        public virtual ActionResult<IEnumerable<Entity>> GetAll()
        {
            var entitites = _repo.GetAll();
            return Ok(entitites);
        }

        protected virtual ActionResult<Entity> GetById(long id)
        {
            var entity = _repo.Get(id);
            if (entity != null)
            {
                return Ok(entity);
            }
            return NotFound();
        }

        [HttpPost]
        public virtual ActionResult<Entity> Create(Entity entity)
        {
            _repo.Create(entity);
            _repo.SaveChanges();
            if (entity != null)
            {
                return CreatedAtRoute(_httpGetRouteName, new { Id = entity.Id }, entity);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public virtual ActionResult<Entity> Update(long id, Entity entity)
        {
            if (id != entity.Id)
            {
                return Conflict();
            }
            
            if (!_repo.Update(entity))
            {
                return NotFound();
            }

            _repo.SaveChanges();
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public virtual ActionResult Delete(long id)
        {
            var entity = _repo.Get(id);
            if (entity == null)
            {
                return NotFound();
            }

            _repo.Delete(entity);
            _repo.SaveChanges();

            return NoContent();
        }
    }
}
