﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WAD_SEM3.Models
{
    public class Category
    {
        [Required(ErrorMessage = "Vui long nhap ten danh muc")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui long nhap ten danh muc")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Vui long nhap ten danh muc")]
        public string Description { get; set; }
    }
}