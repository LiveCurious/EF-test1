using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace test
{
    public class Education
    {
        [Key]
        public Guid EducationGuid { get; set; }

        public Guid EmployeeId { get; set; }
    
        public Guid TrainingId { get; set; }
    }
}