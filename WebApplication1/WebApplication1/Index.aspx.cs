using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EF_Code_First_Tutorials;
using test;

namespace test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var ctx = new Context())
            {
               Employee stud = new Employee() { EmployeeId  =  Guid.NewGuid(), Name = "Test Student", DateOfBith = new DateTime(2000, 12, 12) };
                
               ctx.Employees.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}