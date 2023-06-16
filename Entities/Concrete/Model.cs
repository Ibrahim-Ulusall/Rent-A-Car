using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Model:IEntity
	{
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int BrandId { get; set; }
    }
}
