﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP2.Models
{
    public class WorkOrder
    {
        public int WorkOrderID { get; set; }
        public DateTime DateIn { get; set; }

        public int CarID { get; set; }
        public virtual Car Car { get; set; }
    }
}