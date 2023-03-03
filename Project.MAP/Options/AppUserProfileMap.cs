using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppUserProfileMap:BaseMap<AppUserProfile>
    {
        public AppUserProfileMap()
        {
            ToTable("Profiller");
            Property(x => x.FirstName).HasColumnName("Isim");
            Property(x => x.LastName).HasColumnName("Soyisim");
            
        }
    }
}
