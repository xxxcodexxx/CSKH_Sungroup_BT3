using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSKH_Sungroup_BT3.Models
{
    public class CardSOL
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Chủ sở hữu")]
        public int CustomerId { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime StartDate { get; set; }

        [DisplayName("Tổng số tiền")]
        public long TotalValue { get; set; }

        [DisplayName("Hạng thẻ")]
        public int Rate { get; set; }
    }
}