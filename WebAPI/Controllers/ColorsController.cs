using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstract;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ColorsController : WebApiBaseRepositoryController<Color,IColorService>
	{
        public ColorsController(IColorService colorService) : base(colorService) { }
    }
}
