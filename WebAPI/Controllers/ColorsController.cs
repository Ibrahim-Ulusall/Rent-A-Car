using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ColorsController : ControllerBase
	{
		private readonly IColorService _entityApiService;
		
		public ColorsController(IColorService entityService)
		{
			_entityApiService = entityService;
		}
		[HttpGet("getAll")]

		public IActionResult Get()
		{
			var result = _colorService.GetAll();
			if (result.Success)
				return Ok(result.Data);
			return BadRequest(result.Message);
		}

		[HttpPost("add")]
		public IActionResult Add(Color entity)
		{
			var result = _colorService.Add(entity);

			if (result.Success)
				return Ok(result);
			return BadRequest(result.Message);
		}

		[HttpPost("delete")]
		public IActionResult Delete(Color entity)
		{
			var result = _colorService.Delete(entity);
			if (result.Success)
				return Ok(result);
			return BadRequest(result.Message); 
		}
	}
}
