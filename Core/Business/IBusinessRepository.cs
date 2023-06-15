using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
	public interface IBusinessRepository<T> where T : class,IEntity,new()
	{
		List<T> GetAll();
	}
}
