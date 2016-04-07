using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP2.Models
{
    public class Car
    {
        public int CarID { get; set; }

        [Display(Name = "Marque")]
        public string Brand { get; set; }

        [Display(Name = "Modèle")]
        public string Model { get; set; }

        [Display(Name = "Voiture")]
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