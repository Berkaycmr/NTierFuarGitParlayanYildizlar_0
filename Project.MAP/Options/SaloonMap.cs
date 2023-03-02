using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class SaloonMap:BaseMap<Saloon>
    {
        public SaloonMap()
        {
            Property(x => x.Capacity).HasColumnName("Kapasite");
        }
    }
}
