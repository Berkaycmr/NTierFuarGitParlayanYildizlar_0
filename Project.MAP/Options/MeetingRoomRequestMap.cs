using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class MeetingRoomRequestMap:BaseMap<MeetingRoomRequest>
    {
        public MeetingRoomRequestMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.MeetingRoomID,
                x.RequestID
            });
        }
    }
}
