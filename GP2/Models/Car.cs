using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP2.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public string Fullname
        {
            get
            {
                return Brand + " " + Model;
            }
        }

        //Relation to Customer : Foreign Key
        public int CustomerID { get; set;  }
        public virtual Customer Customer { get; set; }


    }
}