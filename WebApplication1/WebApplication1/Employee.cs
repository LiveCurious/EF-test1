using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace test
{

    public class Employee
    {
        public Employee() { }


        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBith { get; set; }


    }
}