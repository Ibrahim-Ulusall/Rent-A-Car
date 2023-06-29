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
	public class VehicleServiceManager : ManagerBase<Vehicle, IVehicleDal>, IVehicleService
	{
		public VehicleServiceManager(IVehicleDal vehicleDal) : base(vehicleDal) { }

		public override IDataResult<Vehicle> Get(Vehicle entity)
		{
			try
			{
				var existingEntity = _entityDal.Get(vehicle => vehicle.CarId == entity.CarId);
				if (entity == null)
					return new ErrorDataResult<Vehicle>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<Vehicle>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<Vehicle>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<Vehicle>(ex.Message);
			}
		}

		public IDataResult<List<Vehicle>> GetByCategoryId(int id)
		{
			try
			{
				if (id < 0)
					return new ErrorDataResult<List<Vehicle>>(Messages.IdValueLessthanZeroError);
				var existingEntity = _entityDal.GetAll(c => c.CategoryId == id);
				if (existingEntity.Count == 0)
					return new ErrorDataResult<List<Vehicle>>(Messages.ListIsEmpty);
				else
					return new SuccessDataResult<List<Vehicle>>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<List<Vehicle>>(ex.Message);
			}
		}
	}
}
