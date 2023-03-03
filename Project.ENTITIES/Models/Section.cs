using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Section:BaseEntity
    {
        public string SectionType { get; set; }
        public int EmployeeCapacity { get; set; }
        public int VisitorCapacity { get; set; }
        public int Measurement { get; set; }
        public decimal UnitPrice { get; set; }

        public int SaloonID { get; set; }


        //Relational Properties

        public virtual Saloon Saloon { get; set; }
    }
}
