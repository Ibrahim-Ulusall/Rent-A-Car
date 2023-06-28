using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstract;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VehiclesController:WebApiBaseRepositoryController<Vehicle,IVehicleService>
	{
        public VehiclesController(IVehicleService service):base(service)
        {
            
        }
    }
}
