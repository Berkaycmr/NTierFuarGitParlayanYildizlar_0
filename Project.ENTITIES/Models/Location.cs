using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Location:BaseEntity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        //Relational Properties
        public virtual List<Saloon> Saloons { get; set; }

    }
}
