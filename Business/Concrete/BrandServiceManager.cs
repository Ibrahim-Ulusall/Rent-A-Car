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
	public class BrandServiceManager : IBrandService
	{
		IBrandDal _brandDal;
        public BrandServiceManager(IBrandDal brandDal)
        {
			_brandDal = brandDal;
        }
        public List<Brand> GetAll()
		{
			return _brandDal.GetAll();
		}
	}
}
