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
	public class FuelTypeServiceManager : IFuelTypeService
	{
		private readonly IFuelTypeDal _fuelTypeDal;

        public FuelTypeServiceManager(IFuelTypeDal fuelTypeDal)
        {
			_fuelTypeDal = fuelTypeDal;
        }

        public IResult Add(FuelType entity)
		{
			try
			{
				if (entity.FuelTypeId < 0)
					return new ErrorResult(Messages.IdValueLessthanZeroError);
				else if (String.IsNullOrEmpty(entity.FuelTypeName))
					return new ErrorResult(Messages.ValueError);
				else
					_fuelTypeDal.Insert(entity);
					return new SuccessResult(Messages.FuelTypeAdded);
			}
			catch (Exception ex)
			{
				return new ErrorResult(ex.Message);
			}
		}

		public IResult Delete(FuelType entity)
		{
			try
			{
				var existingFuelType = _fuelTypeDal.Get(fuel => fuel.FuelTypeId == entity.FuelTypeId);

				if (entity == null)
					return new ErrorResult(Messages.NullEntityError);
				else if (existingFuelType == null)
					return new ErrorResult(Messages.ExistingEntityError);
				else
					_fuelTypeDal.Delete(entity);
					return new SuccessResult(Messages.DeletedMessage);
			}
			catch(Exception ex)
			{
				return new ErrorResult(ex.Message);
			}
		}

		public IDataResult<FuelType> Get(FuelType entity)
		{
			try
			{
				var result = _fuelTypeDal.Get(fuel => fuel.FuelTypeId == entity.FuelTypeId);
				if (entity == null)
					return new ErrorDataResult<FuelType>(Messages.NullEntityError);
				else if (result == null)
					return new ErrorDataResult<FuelType>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<FuelType>(result);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<FuelType>(ex.Message);
			}
		}

		public IDataResult<List<FuelType>> GetAll()
		{
			try
			{
				List<FuelType> data = _fuelTypeDal.GetAll();
				if (data.Count == 0)
				{
					return new ErrorDataResult<List<FuelType>>(Messages.ListIsEmpty);
				}
				return new SuccessDataResult<List<FuelType>>(data, Messages.GetAllData);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<List<FuelType>>(ex.Message);
			}
		}

		public IResult Update(FuelType entity)
		{
			try
			{
				var existingEntity = _fuelTypeDal.Get(fuel => fuel.FuelTypeId == entity.FuelTypeId);
				if (entity == null)
					return new ErrorResult(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorResult(Messages.ExistingEntityError);
				else
					_fuelTypeDal.Update(entity);
					return new SuccessResult(Messages.UpdateData);
			}
			catch (Exception ex)
			{
				return new ErrorResult(ex.Message);
			}
		}
	}
}
