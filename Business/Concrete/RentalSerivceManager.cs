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
	public class RentalSerivceManager : IRentalService
	{
		IRentalDal _rentalDal;
        public RentalSerivceManager(IRentalDal rentalDal)
        {
			_rentalDal = rentalDal;
        }
        public List<Rental> GetAll()
		{
			return _rentalDal.GetAll();
		}
	}
}
