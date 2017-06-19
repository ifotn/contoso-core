using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContosoCore.Models.SchoolViewModels

{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime ? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}
