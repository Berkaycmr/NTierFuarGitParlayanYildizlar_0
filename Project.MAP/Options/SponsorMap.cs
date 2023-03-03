using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class SponsorMap:BaseMap<Sponsor>
    {
        public SponsorMap()
        {
            Property(x => x.CompanyName).HasColumnName("Firma Adı");
            Property(x => x.Sector).HasColumnName("Sektör");
        }
    }
}
