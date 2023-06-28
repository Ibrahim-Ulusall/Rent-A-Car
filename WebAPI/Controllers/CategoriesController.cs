﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstract;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : WebApiBaseRepositoryController<Category,ICategoryService>
	{
        public CategoriesController(ICategoryService service) : base(service)
        {
            
        }
    }
}
