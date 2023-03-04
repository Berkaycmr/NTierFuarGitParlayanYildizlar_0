using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RequestIssue:BaseEntity
    {
        public int RequestID { get; set; }
        public int IssueID { get; set; }

        //Relational Properties
        public virtual Request Request { get; set; }
        public virtual Issue Issue { get; set; }

    }
}
