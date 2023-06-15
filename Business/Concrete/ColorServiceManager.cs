﻿using Business.Abstract;
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
        public List<Color> GetAll()
		{
			return _colorDal.GetAll();
		}
	}
}
