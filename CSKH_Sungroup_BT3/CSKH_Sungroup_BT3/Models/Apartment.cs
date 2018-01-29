using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Tên căn hộ")]
        public string ApartmentName { get; set; }

        [StringLength(200)]
        [DisplayName("Địa chỉ căn hộ")]
        public string Address { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

        [DisplayName("Giá")]
        public long Price { get; set; }

        [DisplayName("Chủ sở hữu")]
        public int CustomerId { get; set; }
    }
}