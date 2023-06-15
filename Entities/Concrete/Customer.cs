using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Customer:IEntity
	{
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime CustomerDateOfBirth { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string CustomerTelephoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public int CustomerCityId { get; set; }
        public int CustomerDistrictId { get; set; }
    }
}
