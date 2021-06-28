﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WAD_SEM3.Models;
namespace WAD_SEM3.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("T2004E_WAD")
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}