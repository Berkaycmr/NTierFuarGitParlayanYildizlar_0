using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class FairMap:BaseMap<Fair>
    {
        public FairMap()
        {
            Property(x => x.StartDate).HasColumnName("Başlangıc Zamanı");
            Property(x => x.EndDate).HasColumnName("Bitiş Zamanı");
        }
    }
}
