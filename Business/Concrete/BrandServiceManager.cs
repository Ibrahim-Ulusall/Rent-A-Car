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
	public class BrandServiceManager:ManagerBase<Brand,IBrandDal>,IBrandService
	{
        public BrandServiceManager(IBrandDal brandDal) :base(brandDal)
        {
            
        }

		public override IDataResult<Brand> Get(Brand entity)
		{
			try
			{
				Brand existingEntity = _entityDal.Get(brand => brand.BrandId == entity.BrandId);
				if (entity == null)
					return new ErrorDataResult<Brand>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<Brand>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<Brand>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<Brand>(ex.Message);
			}
		}
	}
}
