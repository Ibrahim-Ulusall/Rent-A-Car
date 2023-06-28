using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstract;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StatusController : WebApiBaseRepositoryController<Status,IStatusService>
	{
        public StatusController(IStatusService service) : base(service)
        {
            
        }
    }
}
