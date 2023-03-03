using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class SaloonSponsor:BaseEntity
    {
        public int SaloonID { get; set; }
        public int SponsorID { get; set; }

        //Relational Properties

        public virtual Saloon Saloon { get; set; }
        public virtual Sponsor Sponsor { get; set; }

    }
}
