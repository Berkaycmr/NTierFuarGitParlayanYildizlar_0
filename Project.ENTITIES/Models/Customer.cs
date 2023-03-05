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

        public override string ToString()
        {
            return $"{CompanyName} - {Sector}";
        }


        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<Saloon> Saloons { get; set; }
        public virtual List<CustomerRequest> CustomerRequests { get; set; }

    }
}
