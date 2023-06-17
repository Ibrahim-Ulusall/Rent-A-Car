using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
VehicleServiceManager serviceManager = new VehicleServiceManager(new EfVehicleDal());
var result = serviceManager.Add(new Vehicle { CarId = -1, BrandId = 1, CarDetailsId = 1, CategoryId = 1, 
	ColorId = 1, ModelId = 1, RateOfEngineId = 1 });

Console.WriteLine(result.Message);