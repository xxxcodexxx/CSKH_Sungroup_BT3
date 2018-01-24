using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CSKH_Sungroup_BT3.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        public int Passport { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }
    }
}