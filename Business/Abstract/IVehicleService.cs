using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IVehicleService:IBusinessRepository<Vehicle>
	{
		IDataResult<List<Vehicle>> GetByCategoryId(int id);
	}
}
