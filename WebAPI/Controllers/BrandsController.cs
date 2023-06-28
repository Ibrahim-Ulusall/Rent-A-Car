using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstract;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BrandsController : WebApiBaseRepositoryController<Brand,IBrandService>
	{
        public BrandsController(IBrandService service) : base(service)
        {
            
        }
    }
}
