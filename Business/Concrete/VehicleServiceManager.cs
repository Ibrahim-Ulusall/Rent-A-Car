using Business.Abstract;
using Business.Contans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

		public IResult Add(Vehicle entity)
		{
			if (entity.CarId< 0)
			{
				return new ErrorResult(Messages.IdValueLessthanZeroError);
			}
			_vehicleDal.Insert(entity);
			return new SuccessResult(Messages.CarAdded);
		}

		public IResult Delete(Vehicle entity)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Vehicle> Get(Vehicle entity)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Vehicle>> GetAll()
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Vehicle>> GetByCategoryId()
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<CarDetailDto>> GetDetails()
		{
			throw new NotImplementedException();
		}

		public IResult Update(Vehicle entity)
		{
			throw new NotImplementedException();
		}
	}
}
