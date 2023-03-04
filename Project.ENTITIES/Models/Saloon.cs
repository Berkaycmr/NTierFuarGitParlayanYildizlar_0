using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Saloon:BaseEntity
    {
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string Sector { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
        public int CustomerID { get; set; }


        //Relational Properties
        public virtual List<SaloonSponsor> SaloonSponsors { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
