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
	public class FuelTypeServiceManager : IFuelTypeService
	{
		IFuelTypeDal _fuelTypeDal;
        public FuelTypeServiceManager(IFuelTypeDal fuelTypeDal)
        {
			_fuelTypeDal = fuelTypeDal;
        }
        public List<FuelType> GetAll()
		{
			return _fuelTypeDal.GetAll();
		}
	}
}
