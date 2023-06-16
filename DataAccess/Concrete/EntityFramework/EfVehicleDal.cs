using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.DatabaseContext;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfVehicleDal : EfEntityRepositoryBase<Vehicle,
		EntityFrameworkRentACarDatabaseContext>, IVehicleDal
	{
		public List<CarDetailDto> GetCarDetails()
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
							 select new CarDetailDto { 
								 BrandName = brand.BrandName, 
								 ModelName = model.ModelName, 
								 ColorName = color.ColorName, 
								 DetailId = car.CarId 
							 };
				return result.ToList();
			}
		}
	}
}
