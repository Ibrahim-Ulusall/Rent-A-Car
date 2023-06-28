using Business.Abstract;
using Business.Contans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class FuelTypeServiceManager : ManagerBase<FuelType, IFuelTypeDal>, IFuelTypeService
	{

		public FuelTypeServiceManager(IFuelTypeDal fuelTypeDal) : base(fuelTypeDal) { }

		public override IDataResult<FuelType> Get(FuelType entity)
		{
			try
			{
				FuelType existingEntity = _entityDal.Get(fuel => fuel.FuelTypeId == entity.FuelTypeId);
				if (entity == null)
					return new ErrorDataResult<FuelType>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<FuelType>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<FuelType>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<FuelType>(ex.Message);
			}
		}

	}
}
