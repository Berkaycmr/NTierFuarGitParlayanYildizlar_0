using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ToiletRequest:BaseEntity
    {
        public int ToiletID { get; set; }
        public int RequestID { get; set; }

        //Relational Properties

        public virtual Toilet Toilet { get; set; }
        public virtual Request Request { get; set; }

    }
}
