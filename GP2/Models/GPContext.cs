using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GP2.Models
{
    public class GPContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
    }

}