using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Transmission:IEntity
	{
        public int GearId { get; set; }
        public int GearType { get; set; }
    }
}
