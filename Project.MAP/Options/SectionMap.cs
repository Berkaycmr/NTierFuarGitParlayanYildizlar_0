using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class SectionMap:BaseMap<Section>
    {
        public SectionMap()
        {
            Property(x => x.SectionType).HasColumnName("Bölüm Türü");
        }
    }
}
