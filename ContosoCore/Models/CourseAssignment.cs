using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoCore.Models
{
    public class CourseAssignment
    {
        public int CourseID { get; set; }
        public int InstructorID { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
        public string Term { get; set; }

    }
}
