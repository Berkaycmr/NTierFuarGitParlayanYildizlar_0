using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class CustomerRequest:BaseEntity
    {
        public int CustomerID { get; set; }
        public int RequestID { get; set; }



        //Relational Properties
        public virtual Customer Customer { get; set; }
        public virtual Request Request { get; set; }
    }
}
