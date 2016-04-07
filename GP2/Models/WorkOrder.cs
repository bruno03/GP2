using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP2.Models
{
    public class WorkOrder
    {
        public int WorkOrderID { get; set; }

        [Display(Name = "Date d'entrée")]
        public DateTime DateIn { get; set; }

        [Display(Name = "Client")]
        public new Customer Customer
        {
            get
            {
                return Car.Customer; 
            }
        }

        //Relation to Car : Foreign Key
        public int CarID { get; set; }
        public virtual Car Car { get; set; }



        public virtual List<WorkItem> WorkItems { get; set; }
    }
}