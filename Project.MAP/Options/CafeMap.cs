using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CafeMap:BaseMap<Cafe>
    {
        public CafeMap()
        {
            Property(x => x.UnitPrice).HasColumnType("Money");
        }
    }
}
