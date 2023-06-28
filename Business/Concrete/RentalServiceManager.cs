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
	public class RentalServiceManager:ManagerBase<Rental,IRentalDal> , IRentalService
	{
		public RentalServiceManager(IRentalDal rentalDal) : base(rentalDal) { }

		public override IDataResult<Rental> Get(Rental entity)
		{
			try
			{
				Rental existingEntity = _entityDal.Get(rental => rental.RentalId == entity.RentalId);
				if (entity == null)
					return new ErrorDataResult<Rental>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<Rental>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<Rental>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<Rental>(ex.Message);
			}
		}
	}
}
