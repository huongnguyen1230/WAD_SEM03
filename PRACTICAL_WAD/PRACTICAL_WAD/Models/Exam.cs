using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PRACTICAL_WAD.Models
{
    public class Exam
    {
        [Key]
        public string ExamSubject { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public string ExamDate { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string Classroom { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required]
        public string Status { get; set; }


    }
}