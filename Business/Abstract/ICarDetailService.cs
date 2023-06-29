using Core.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICarDetailService:IBusinessRepository<CarDetail>
	{
		IDataResult<List<CarDetailDto>> carDetails();
	}
}
