using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP2.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Display(Name = "Prénom")]
        public string Firstname { get; set; }

        [Display(Name = "Nom")]
        public string Lastname { get; set; }

        [Display(Name = "Client")]
        public new string FullName
        {
            get
            {
                return Firstname + " " + Lastname; 
            }
        }


        public virtual List<Car> Cars { get; set; }

    }
}