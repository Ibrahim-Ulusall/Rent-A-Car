using Business.Abstract;
using Business.Contans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.DatabaseContext;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CarDetailServiceManager : ManagerBase<CarDetail, ICarDetailDal>, ICarDetailService
	{
		public CarDetailServiceManager(ICarDetailDal carDetail) : base(carDetail) { }

		public IDataResult<List<CarDetailDto>> carDetails()
		{

			using (EntityFrameworkRentACarDatabaseContext context = new EntityFrameworkRentACarDatabaseContext())
			{
				var result = from car in context.Vehicles
							 join brand in context.Brands
							 on car.BrandId equals brand.BrandId
							 join color in context.Colors
							 on car.ColorId equals color.ColorId
							 join model in context.Models
							 on car.ModelId equals model.ModelId
							 join detail in context.CarDetails
							 on car.CarDetailId equals detail.CarDetailId
							 join engine in context.RateOfEngines
							 on car.RateOfEngineId equals engine.EngineId
							 join fuel in context.FuelTypes
							 on detail.FuelTypeId equals fuel.FuelTypeId
							 select new CarDetailDto
							 {
								 DetailId = detail.CarDetailId,
								 BrandName = brand.BrandName,
								 ColorName = color.ColorName,
								 ModelName = model.ModelName,
								 EnginePower = engine.RateofEngine,
								 ChassisNumber = detail.ChassisNumber,
								 FuelType = fuel.FuelTypeName
							 };
				if (result.Count() == 0)
					return new ErrorDataResult<List<CarDetailDto>>(Messages.ListIsEmpty);
				return new SuccessDataResult<List<CarDetailDto>>(result.ToList());
			}

		}

		public override IDataResult<CarDetail> Get(CarDetail entity)
		{
			try
			{
				CarDetail existingEntity = _entityDal.Get(detail => detail.CarDetailId == entity.CarDetailId);
				if (entity == null)
					return new ErrorDataResult<CarDetail>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<CarDetail>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<CarDetail>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<CarDetail>(ex.Message);
			}
		}
	}
}
