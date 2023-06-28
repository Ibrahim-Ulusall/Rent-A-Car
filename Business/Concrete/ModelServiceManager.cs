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
	public class ModelServiceManager:ManagerBase<Model,IModelDal>,IModelService
	{
        public ModelServiceManager(IModelDal modelDal) : base(modelDal) { }

		public override IDataResult<Model> Get(Model entity)
		{
			try
			{
				Model existingEntity = _entityDal.Get(model => model.ModelId == entity.ModelId);
				if (entity == null)
					return new ErrorDataResult<Model>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<Model>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<Model>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<Model>(ex.Message);
			}
		}
	}
}
