using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Vehicle:IEntity
	{
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        public int CategoryId { get; set; }
        public int RateOfEngineId { get; set; }
        public int CarDetailId { get; set; }
    }
}
