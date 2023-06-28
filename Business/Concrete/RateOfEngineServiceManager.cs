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
	public class RateOfEngineServiceManager:ManagerBase<RateOfEngine,IRateOfEngineDal> , IRateOfEngineService
	{
        public RateOfEngineServiceManager(IRateOfEngineDal rateOfEngineDal) : base(rateOfEngineDal) { }

		public override IDataResult<RateOfEngine> Get(RateOfEngine entity)
		{
			try
			{
				RateOfEngine existingEntity = _entityDal.Get(engine => engine.EngineId == entity.EngineId);
				if (entity == null)
					return new ErrorDataResult<RateOfEngine>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<RateOfEngine>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<RateOfEngine>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<RateOfEngine>(ex.Message);
			}
		}
	}
}
