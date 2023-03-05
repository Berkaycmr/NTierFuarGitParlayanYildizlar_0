using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CustomerMap:BaseMap<Customer>
    {
        public CustomerMap()
        {
            Property(x => x.CompanyName).HasColumnName("Şirket Adı");
            Property(x => x.Country).HasColumnName("Ülke");
            Property(x => x.Sector).HasColumnName("Sektör");

        }
    }
}
