using Business.Contans;
using Core.Business;
using Core.DataAccess.EntityFramework;
using Core.Entites;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public abstract class ManagerBase<TEntity, TEntityDal> : IBusinessRepository<TEntity>
		where TEntity : class, IEntity, new()
		where TEntityDal : class, IEntityRepository<TEntity>
	{
		internal readonly TEntityDal _entityDal;
        public ManagerBase(TEntityDal entityDal)
        {
			_entityDal = entityDal;
        }
        public virtual IResult Add(TEntity entity)
		{
			try
			{
				if (entity == null)
					return new ErrorResult(Messages.NullEntityError);
				_entityDal.Insert(entity);
				return new SuccessResult(Messages.AddedData);
			}
			catch (Exception ex)
			{
				return new ErrorResult(ex.Message);
			}
		}

		public virtual IResult Delete(TEntity entity)
		{
			try
			{
				if (entity == null)
					return new ErrorResult(Messages.NullEntityError);
				_entityDal.Delete(entity);
				return new SuccessResult(Messages.DeletedMessage);
			}
			catch (Exception ex)
			{
				return new ErrorResult(ex.Message);
			}
		}

		public abstract IDataResult<TEntity> Get(TEntity entity);
		public virtual IDataResult<List<TEntity>> GetAll()
		{
			List<TEntity> datas = _entityDal.GetAll();
			if (datas.Count == 0)
				return new ErrorDataResult<List<TEntity>>(Messages.ListIsEmpty);
			return new SuccessDataResult<List<TEntity>>(datas,Messages.GetAllData);
		}

		public virtual IResult Update(TEntity entity)
		{
			try
			{
				if (entity == null)
					return new ErrorResult(Messages.NullEntityError);
				_entityDal.Update(entity);
				return new SuccessResult(Messages.UpdateData);
			}
			catch (Exception ex)
			{
				return new ErrorResult(ex.Message);
			}
		}
	}
}
