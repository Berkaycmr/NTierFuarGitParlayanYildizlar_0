using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Customer:BaseEntity
    {
        public string CompanyName { get; set; }
        public string Sector { get; set; }
        public string Country { get; set; }
        public int AppUserID { get; set; }



        //Relational Properties
        public AppUser AppUser { get; set; }

    }
}
