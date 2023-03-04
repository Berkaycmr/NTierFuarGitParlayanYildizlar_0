using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Request:BaseEntity
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime DueDate { get; set; }
        public int Measurement { get; set; }



        //Relational Properties


        public virtual List<CustomerRequest> CustomerRequests { get; set; }
        public virtual List<RequestIssue> RequestIssues { get; set; }

    }
}
