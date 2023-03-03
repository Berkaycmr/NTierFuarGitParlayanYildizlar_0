using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class MeetingRoomMap:BaseMap<MeetingRoom>
    {
        public MeetingRoomMap()
        {
            Property(x => x.Title).HasColumnName("Ünvan");
        }


    }
}
