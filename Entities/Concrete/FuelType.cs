using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class FuelType:IEntity
	{
        public int FuelTypeId { get; set; }
        public string FuelTypeName { get; set; }
    }
}
