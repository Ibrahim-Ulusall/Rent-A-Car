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
        public int FuelTypeId { get; set; } // Yakıt Türü
        public int TransmissionId { get; set; } // Vites Türü
        public long Kilometer { get; set; }
        public string EngineNumber { get; set; } // Motor No
        public string ChassisNumber { get; set; } // Şasi No
        public string Description { get; set; }
        public string Plates { get; set; } // Plaka
        public string imagePath { get; set; }

    }
}
