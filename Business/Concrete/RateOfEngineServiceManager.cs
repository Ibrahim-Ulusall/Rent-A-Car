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
	public class RateOfEngineServiceManager : IRateOfEngineService
	{
		IRateOfEngineDal _rateOfEngine;
        public RateOfEngineServiceManager(IRateOfEngineDal rateOfEngineDal)
        {
			_rateOfEngine = rateOfEngineDal;
        }
        public List<RateOfEngine> GetAll()
		{
			return _rateOfEngine.GetAll();
		}
	}
}
