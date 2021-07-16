using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace T2004E_WAD.Models
{
    public class Brand
    { //thuoc tinh co ban cua doi tuong
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}