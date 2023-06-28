using Core.Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Abstract
{
	public interface IWebApiRepositotyBase<TEntity> where TEntity : class,IEntity,new()
	{
		IActionResult Get();
		IActionResult Add(TEntity entity);
		IActionResult Delete(TEntity entity);
		IActionResult Update(TEntity entity);
	}
}
