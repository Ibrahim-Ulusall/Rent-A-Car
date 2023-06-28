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
	public class TransmissionServiceManager:ManagerBase<Transmission,ITransmissionDal>,ITransmissonService
	{
        public TransmissionServiceManager(ITransmissionDal transmissionDal): base(transmissionDal) { }

		public override IDataResult<Transmission> Get(Transmission entity)
		{
			try
			{
				Transmission existingEntity = _entityDal.Get(transmission => transmission.GearId == entity.GearId);
				if (entity == null)
					return new ErrorDataResult<Transmission>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<Transmission>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<Transmission>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<Transmission>(ex.Message);
			}
		}
	}
}
