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
	public class ColorServiceManager : IColorService
	{
		IColorDal _colorDal;
        public ColorServiceManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color entity)
		{
			var result = _colorDal.Get(color => color.ColorName.ToLower() == entity.ColorName.ToLower());
			if (result.ColorName.ToLower() == entity.ColorName.ToLower())
				return new ErrorResult(Messages.GivenValueCurrentError);
			_colorDal.Insert(entity);
			return new SuccessResult(Messages.ColorAdded);
		}

		public IResult Delete(Color entity)
		{
			if (entity.ColorId < 0)
				return new ErrorResult(Messages.IdValueLessthanZeroError);
			_colorDal.Delete(entity);
			return new SuccessResult(Messages.ColorDeleted);
		}

		public IDataResult<Color> Get(Color entity)
		{
			return new SuccessDataResult<Color>(_colorDal.Get(color => color.ColorId == entity.ColorId),Messages.ColorListed);
		}

		public IDataResult<List<Color>> GetAll()
		{
			return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorListed);
		}

		public IResult Update(Color entity)
		{
			var result = _colorDal.Get(color => color.ColorName.ToLower() == entity.ColorName.ToLower());
			if (result.ColorName.ToLower() == entity.ColorName.ToLower())
				return new ErrorResult(Messages.CurrentValueInSystemError);
			return new SuccessResult(Messages.ColorUpdated);
		}
	}
}
