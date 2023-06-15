using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class VehicleServiceManager : IVehicleService
	{
		IVehicleDal _vehicleDal;
		public VehicleServiceManager(IVehicleDal vehicleDal)
		{
			_vehicleDal = vehicleDal;
		}

		public List<Vehicle> GetAll()
		{
			return _vehicleDal.GetAll();
		}
	}
}
