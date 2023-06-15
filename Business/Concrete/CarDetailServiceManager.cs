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
	public class CarDetailServiceManager : ICarDetailService
	{
		ICarDetailDal _carDetailDal;

        public CarDetailServiceManager(ICarDetailDal carDetailDal)
        {
			_carDetailDal = carDetailDal;
        }

        public List<CarDetail> GetAll()
		{
			return _carDetailDal.GetAll();
		}
	}
}
