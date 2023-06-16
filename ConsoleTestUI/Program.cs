using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

DistrictServiceManager serviceManager = new DistrictServiceManager(new EfDistrictDal());

foreach (var item in serviceManager.GetAll())
{
	Console.WriteLine(item.DistrictName);
}