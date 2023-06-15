using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CustomerServiceManager : ICustomerService
	{
		ICustomerDal _customerDal;
        public CustomerServiceManager(ICustomerDal customerDal)
        {
			_customerDal = customerDal;
        }
        public List<Customer> GetAll()
		{
			return _customerDal.GetAll();
		}
	}
}
