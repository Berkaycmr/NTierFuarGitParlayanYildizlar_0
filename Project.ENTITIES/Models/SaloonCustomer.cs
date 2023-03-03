using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class SaloonCustomer:BaseEntity
    {
        public int SaloonID { get; set; }
        public int CustomerID { get; set; }

        //Relational Properties

        public virtual Saloon Saloon { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
