using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PRACTICAL_WAD.Models;

namespace PRACTICAL_WAD.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("PRAC_WAD")
        {
        }
        public DbSet<Exam> Exams { get; set; }

    }
}