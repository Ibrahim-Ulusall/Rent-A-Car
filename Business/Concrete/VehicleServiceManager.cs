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
			_vehicleDal.Delete(entity);
			return new SuccessResult(Messages.CarDeleted);
		}

		public IDataResult<Vehicle> Get(Vehicle entity)
		{
			if (entity.CarId < 0)
				return new ErrorDataResult<Vehicle>(Messages.IdValueLessthanZeroError);
			_vehicleDal.Get(car => car.CarId == entity.CarId);
			return new SuccessDataResult<Vehicle>();
		}

		public IDataResult<List<Vehicle>> GetAll()
		{
			return new SuccessDataResult<List<Vehicle>>(_vehicleDal.GetAll(), Messages.CarListed);
		}

		public IDataResult<List<Vehicle>> GetByCategoryId(int id)
		{
			if (id<0)
				return new ErrorDataResult<List<Vehicle>>(Messages.IdValueLessthanZeroError);
			_vehicleDal.GetAll(car => car.CategoryId == id);
			return new SuccessDataResult<List<Vehicle>>(Messages.CategoriesListed);
		}

		public IResult Update(Vehicle entity)
		{
			if (entity.CarId < 0)
				return new ErrorResult(Messages.IdValueLessthanZeroError);
			return new SuccessResult(Messages.CarUpdated);

		}
	}
}
