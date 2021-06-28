﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using T2004E_WAD.Models;

namespace T2004E_WAD.Context
{
    public class DataContext :DbContext
    {
        public DataContext() : base("WAD_T2004E")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}