using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ModelServiceManager serviceManager = new ModelServiceManager(new EfModelDal());

foreach (var item in serviceManager.GetAll())
{
    Console.WriteLine(item.ModelName);
}