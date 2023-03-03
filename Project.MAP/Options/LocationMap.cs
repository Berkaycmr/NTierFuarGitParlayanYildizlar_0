using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class LocationMap:BaseMap<Location>
    {
        public LocationMap()
        {
            Property(x => x.District).HasColumnName("İlçe");
        }
    }
}
