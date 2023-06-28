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
	public class CityServiceManager:ManagerBase<City,ICityDal> , ICityService
	{
		public CityServiceManager(ICityDal cityDal) : base(cityDal) { }

		public override IDataResult<City> Get(City entity)
		{
			try
			{
				City existingEntity = _entityDal.Get(city => city.CityId == entity.CityId);
				if (entity == null)
					return new ErrorDataResult<City>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<City>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<City>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<City>(ex.Message);
			}
		}
	}
}
