﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Rental:IEntity
	{
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int StatusId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
