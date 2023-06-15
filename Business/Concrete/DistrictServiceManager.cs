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
	public class DistrictServiceManager : IDistrictService
	{
		IDistrictDal _districtDal;
        public DistrictServiceManager(IDistrictDal districtDal)
        {
			_districtDal = districtDal;
        }
        public List<District> GetAll()
		{
			return _districtDal.GetAll();
		}
	}
}
