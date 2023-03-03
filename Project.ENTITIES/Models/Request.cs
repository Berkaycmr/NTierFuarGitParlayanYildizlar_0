using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Request:BaseEntity
    {
        public string Description { get; set; }
        public int CustomerID { get; set; }


        //Relational Properties

        public virtual List<ToiletRequest> ToiletRequests { get; set; }
        public virtual List<CafeRequest> CafeRequest { get; set; }
        public virtual List<MeetingRoomRequest> MeetingRoomRequests { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
