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
	public class CarDetailServiceManager:ManagerBase<CarDetail,ICarDetailDal> , ICarDetailService
	{
        public CarDetailServiceManager(ICarDetailDal carDetail) : base(carDetail) { }

		public override IDataResult<CarDetail> Get(CarDetail entity)
		{
			try
			{
				CarDetail existingEntity = _entityDal.Get(detail => detail.CarDetailId == entity.CarDetailId);
				if (entity == null)
					return new ErrorDataResult<CarDetail>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<CarDetail>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<CarDetail>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<CarDetail>(ex.Message);
			}
		}
	}
}
