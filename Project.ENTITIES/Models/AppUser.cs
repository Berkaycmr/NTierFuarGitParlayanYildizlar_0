using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properties

        public AppUserProfile Profile { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
