using Core.Entites.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
	public class CarDetailDto:IDto
	{
        public int DetailId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string ColorName { get; set; }
        public decimal EnginePower { get; set; }
        public string ChassisNumber { get; set; }
        public string FuelType { get; set; }
    }
}
