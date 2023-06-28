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
	public class ColorServiceManager :ManagerBase<Color,IColorDal> ,IColorService
	{
        public ColorServiceManager(IColorDal colorDal) : base(colorDal) { }
        
		public override IDataResult<Color> Get(Color entity)
		{
			try
			{
				Color existingEntity = _entityDal.Get(color => color.ColorId == entity.ColorId);
				if (entity == null)
					return new ErrorDataResult<Color>(Messages.NullEntityError);
				else if (existingEntity == null)
					return new ErrorDataResult<Color>(Messages.ExistingEntityError);
				else
					return new SuccessDataResult<Color>(existingEntity);
			}
			catch (Exception ex)
			{
				return new ErrorDataResult<Color>(ex.Message);
			}
		}
	}
	}
}
