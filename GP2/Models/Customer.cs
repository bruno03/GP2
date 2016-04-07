using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP2.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public new string FullName
        {
            get
            {
                return Firstname + " " + Lastname; 
            }
        }

    }
}