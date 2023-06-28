using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstract;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransmissionController : WebApiBaseRepositoryController<Transmission,ITransmissonService>
	{
        public TransmissionController(ITransmissonService service) : base(service)
        {
            
        }
    }
}
