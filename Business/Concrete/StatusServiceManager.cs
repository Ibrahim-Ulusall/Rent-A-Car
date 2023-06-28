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
	public class StatusServiceManager:ManagerBase<Status,IStatusDal> , IStatusService
	{
        public StatusServiceManager(IStatusDal statusDal) : base(statusDal) { }

		public override IDataResult<Status> Get(Status entity)
		{
			try
			{
				Status existingEntity = _entityDal.Get(status => status.StatusId == entity.StatusId);
				if (entity == null)
					return new ErrorDataResult<Status>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<Status>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<Status>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<Status>(ex.Message);
			}
		}
	}
}
