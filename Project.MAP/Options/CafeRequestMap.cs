using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CafeRequestMap:BaseMap<CafeRequest>
    {
        public CafeRequestMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.CafeID,
                x.RequestID
            });
        }
    }
}
