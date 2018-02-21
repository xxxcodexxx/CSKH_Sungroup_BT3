using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CSKH_Sungroup_BT3.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [DisplayName("Họ đệm")]
        public string FirstName { get; set; }

        [StringLength(100)]
        [DisplayName("Tên")]
        public string LastName { get; set; }

        [StringLength(30)]
        [DisplayName("CMND/Hộ chiếu")]
        public string Passport { get; set; }

        [StringLength(200)]
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
        
        public string Email { get; set; }

        [StringLength(30)]
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}