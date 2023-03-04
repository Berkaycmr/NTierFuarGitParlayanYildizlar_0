using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Issue:BaseEntity
    {
        public string Description { get; set; }
        public DateTime RecoveryTime { get; set; }

        //Relational Properties

        public virtual List<RequestIssue> RequestIssues { get; set; }
    }
}
