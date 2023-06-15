using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class CarDetail:IEntity
	{
        public int DetailId { get; set; }
        public string Description { get; set; }
        public string Plates { get; set; } // Plaka
    }
}
