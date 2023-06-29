using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

CarDetailServiceManager serviceManager = new CarDetailServiceManager(new EfCarDetailsDal());

foreach (var item in serviceManager.carDetails().Data)
{
	Console.WriteLine(item.DetailId.ToString() + " " + 
		item.BrandName + " " + 
		item.ModelName + " " + item.ColorName);
}