using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Cafe:BaseEntity
    {
        public int Measurement { get; set; }
        public decimal UnitPrice { get; set; }
        public int DeliveryTime { get; set; }


        //Relational Properties

        public virtual List<CafeRequest> CafeRequests { get; set; }
    }
}
