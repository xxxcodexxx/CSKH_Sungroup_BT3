using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSKH_Sungroup_BT3.Models
{
    public class Apartment
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(100)]
        public string ApartmentName { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public bool Status { get; set; }

        public long Price { get; set; }

        public int CustomerId { get; set; }
    }
}