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
        public int CarDetailId { get; set; }
        public int FuelTypeId { get; set; } // Yakıt Türü
        public int TransmissionId { get; set; } // Vites Türü
        public int Kilometer { get; set; }
        public string ChassisNumber { get; set; } // Şasi No
        public string Descriptions { get; set; }
        public string Plate { get; set; } // Plaka
        public string ImagePath { get; set; }

    }
}
