using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
VehicleServiceManager serviceManager = new VehicleServiceManager(new EfVehicleDal());

//foreach (var item in serviceManager.GetAll().Data)
//{
//	Console.WriteLine(item.CategoryId);
//}

var result = serviceManager.Add(new Vehicle { CarId = -1, BrandId = 1, CarDetailId = 1, CategoryId = 1, 
	ColorId = 1, ModelId = 1, RateOfEngineId = 1 });

BrandServiceManager brandService = new BrandServiceManager(new EfBrandDal());
foreach (var item in brandService.GetAll().Data)
	Console.WriteLine(item.BrandName);

//Console.WriteLine(result.Message);