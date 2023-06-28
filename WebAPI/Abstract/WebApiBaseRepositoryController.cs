﻿using Core.Business;
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
		where TEntityService : class,IBusinessRepository<TEntity>,new()
	{
		private readonly TEntityService _entityService;

        public WebApiBaseRepositoryController(TEntityService entityService)
        {
			_entityService = entityService;    
        }

		[HttpGet("add")]
        public virtual IActionResult Add(TEntity entity)
		{
			var result = _entityService.Add(entity);
			if (result.Success)
				return Ok(result);
			return BadRequest(result.Message);
		}

		public virtual IActionResult Delete(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public virtual IActionResult Get()
		{
			throw new NotImplementedException();
		}

		public virtual IActionResult Update(TEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
