using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP2.Models
{
    public class WorkItem
    {
        public int WorkItemID { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Quantité")]
        public float Quantity { get; set; }

        [Display(Name = "Prix unitaire")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Prix finale")]
        public decimal FinalPrice { get; set;  }

        //Relation with WorkOrder (Foreign Key)
        public int WorkOrderID { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}