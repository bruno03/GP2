using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP2.Models
{
    public class WorkItem
    {
        public int WorkItemID { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal FinalPrice { get; set;  }

        //Relation with WorkOrder (Foreign Key)
        public int WorkOrderID { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}