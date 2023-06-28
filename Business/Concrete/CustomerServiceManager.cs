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
	public class CustomerServiceManager:ManagerBase<Customer,ICustomerDal>,ICustomerService
	{
        public CustomerServiceManager(ICustomerDal customerDal) : base(customerDal) { }

		public override IDataResult<Customer> Get(Customer entity)
		{
			try
			{
				Customer existingEntity = _entityDal.Get(customer => customer.CustomerId == entity.CustomerId);
				if (entity == null)
					return new ErrorDataResult<Customer>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<Customer>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<Customer>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<Customer>(ex.Message);
			}
		}
	}
}
