using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiTap2.Models
{
    public class KhachHang
    {
        [Key]
        public string TenKH { get; set; }
        public string MaKH { get; set; }
    }
}