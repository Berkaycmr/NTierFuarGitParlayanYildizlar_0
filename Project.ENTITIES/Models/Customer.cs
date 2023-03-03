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
        public int RequestID { get; set; }



        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual Request Request { get; set; }
        public virtual List<SaloonCustomer> SaloonCustomers { get; set; }

    }
}
