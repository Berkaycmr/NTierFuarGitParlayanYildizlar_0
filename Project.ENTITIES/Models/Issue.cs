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
        public int RecoveryTime { get; set; }

        public override string ToString()
        {
            return $"{Description}-- Onarım süresi = {RecoveryTime} gün.";
        }

        //Relational Properties

        public virtual List<RequestIssue> RequestIssues { get; set; }
    }
}
