﻿using Core.Entites;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
	public interface IBusinessRepository<T> where T : class, IEntity, new()
	{
		IResult Add(T entity);
		IResult Delete(T entity);
		IResult Update(T entity);
		IDataResult<T> Get(T entity);
		IDataResult<List<T>> GetAll();
		IDataResult<List<T>> GetByCategoryId();
	}
}
