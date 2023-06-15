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
	public class ModelServiceManager : IModelService
	{
		IModelDal _modelDal;
        public ModelServiceManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }
        public List<Model> GetAll()
		{
			return _modelDal.GetAll();
		}
	}
}
