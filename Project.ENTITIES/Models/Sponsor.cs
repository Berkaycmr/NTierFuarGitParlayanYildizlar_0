using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Sponsor:BaseEntity
    {
        public string CompanyName { get; set; }
        public string Sector { get; set; }

        //Relational Properties
        public virtual List<SaloonSponsor> SaloonSponsors { get; set; }

    }
}
