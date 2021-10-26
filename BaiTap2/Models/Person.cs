using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTap2.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string NamePerson { get; set; }
        public string PhoneNumber { get; set; }
    }
}