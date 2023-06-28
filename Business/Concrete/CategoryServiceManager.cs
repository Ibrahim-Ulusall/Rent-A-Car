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
	public class CategoryServiceManager:ManagerBase<Category,ICategoryDal> , ICategoryService
	{
        public CategoryServiceManager(ICategoryDal categoryDal) : base(categoryDal) { }

		public override IDataResult<Category> Get(Category entity)
		{
			try
			{
				Category existingEntity = _entityDal.Get(category => category.CategoryId == entity.CategoryId);
				if (entity == null)
					return new ErrorDataResult<Category>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<Category>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<Category>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<Category>(ex.Message);
			}
		}
	}
}
