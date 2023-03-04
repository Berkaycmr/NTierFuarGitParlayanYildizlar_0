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
            
            Property(x => x.Name).HasColumnName("İsim");
            Property(x => x.UnitPrice).HasColumnName("Fiyat");
            Property(x => x.DueDate).HasColumnName("Teslim Tarihi");
            Property(x => x.Measurement).HasColumnName("Büyüklük");
        }
    }
}
