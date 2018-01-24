using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSKH_Sungroup_BT3.Models
{
    public class CardSOL
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime StartDate { get; set; }

        public long TotalValue { get; set; }
        
        public int Rate { get; set; }
    }
}