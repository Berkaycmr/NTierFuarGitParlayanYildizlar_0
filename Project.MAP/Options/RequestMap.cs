using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class RequestMap:BaseMap<Request>
    {
        public RequestMap()
        {
            Property(x=>x.Description).HasColumnName("Açıklama");
        }
    }
}
