using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Saloon:BaseEntity
    {
        public int Capacity { get; set; }
        public string Sector { get; set; }
        public int FairID { get; set; }
        public int LocationID { get; set; }

        //Relational Properties
        public Fair Fair { get; set; }
        public Location Location { get; set; }

    }
}
