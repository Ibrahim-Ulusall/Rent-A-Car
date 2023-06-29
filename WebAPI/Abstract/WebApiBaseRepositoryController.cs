using Core.Business;
using Core.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Abstract
{
	[Route("api/[controller]")]
	[ApiController]
	public abstract class WebApiBaseRepositoryController<TEntity, TEntityService> : ControllerBase, 
		IWebApiRepositotyBase<TEntity>
		where TEntity :class,IEntity,new()
		where TEntityService : class,IBusinessRepository<TEntity>
	{
		public readonly TEntityService _entityService;

        public WebApiBaseRepositoryController(TEntityService entityService)
        {
			_entityService = entityService;    
        }

		[HttpPost("add")]
        public virtual IActionResult Add(TEntity entity)
		{
			var result = _entityService.Add(entity);
			if (result.Success)
				return Ok(result);
			return BadRequest(result.Message);
		}

		[HttpPost("delete")]
		public virtual IActionResult Delete(TEntity entity)
		{
			var result = _entityService.Delete(entity);
			if (result.Success)
				return Ok(result);
			return BadRequest(result.Message);
		}
		[HttpGet("getAll")]
		public virtual IActionResult Get()
		{
			var result = _entityService.GetAll();
			if (result.Success)
				return Ok(result.Data);
			return BadRequest(result.Message);
		}
		[HttpPost("update")]
		public virtual IActionResult Update(TEntity entity)
		{
			var result = _entityService.Update(entity);
			if (result.Success)
				return Ok(result);
			return BadRequest(result.Message);
		}
	}
}
