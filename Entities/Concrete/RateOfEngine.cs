﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class RateOfEngine:IEntity
	{
        public int EngineId { get; set; }
        public decimal RateofEngine { get; set; }

    }
}