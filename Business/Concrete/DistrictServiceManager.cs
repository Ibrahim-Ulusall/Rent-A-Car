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
	public class DistrictServiceManager:ManagerBase<District,IDistrictDal> , IDistrictService
	{
		public DistrictServiceManager(IDistrictDal districtDal) : base(districtDal) { }

		public override IDataResult<District> Get(District entity)
		{
			try
			{
				District existingEntity = _entityDal.Get(district => district.DistrictId == entity.DistrictId);
				if (entity == null)
					return new ErrorDataResult<District>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<District>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<District>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<District>(ex.Message);
			}
		}
	}
}
