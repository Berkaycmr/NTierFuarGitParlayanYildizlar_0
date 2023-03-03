﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public  class CafeRequest:BaseEntity
    {
        public int CafeID { get; set; }
        public int RequestID { get; set; }

        //Relational Properties
        public virtual Cafe Cafe { get; set; }
        public virtual Request Request { get; set; }

    }
}
