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
	public class TransmissionServiceManager : ITransmissonService
	{
		ITransmissionDal _transmissionDal;
        public TransmissionServiceManager(ITransmissionDal transmissionDal)
        {
			_transmissionDal = transmissionDal;
        }
        public List<Transmission> GetAll()
		{
			return _transmissionDal.GetAll();
		}
	}
}
