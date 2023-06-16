using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Status:IEntity
	{
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
