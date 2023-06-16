using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

VehicleServiceManager serviceManager = new VehicleServiceManager(new EfVehicleDal());
foreach (var item in serviceManager.GetDetails())
{
    Console.WriteLine("{0}\t{1}\t{2}\t{3}",item.DetailId,item.BrandName,item.ModelName,item.ColorName);
}