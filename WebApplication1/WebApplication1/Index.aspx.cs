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

            InitializeValues();
            using (var ctx = new Context())
            {
                var list =  from s in ctx.Employees
                            select s.Name;

                var t = 10;
            }
        }

        private void InitializeValues()
        {
            using (var ctx = new Context())
            {

                IList<Employee> listOfEmployees = new List<Employee>();

                listOfEmployees.Add(new Employee()
                {
                    EmployeeId = Guid.NewGuid(),
                    Name = "Vasya Pupkin",
                    DateOfBith = new DateTime(1991, 12, 12)
                });
                listOfEmployees.Add(new Employee()
                {
                    EmployeeId = Guid.NewGuid(),
                    Name = "Petya Vasechkin",
                    DateOfBith = new DateTime(1992, 03, 23)
                });
                listOfEmployees.Add(new Employee()
                {
                    EmployeeId = Guid.NewGuid(),
                    Name = "Kolya Petrov",
                    DateOfBith = new DateTime(1993, 04, 04)
                });

                foreach (Employee std in listOfEmployees)
                {
                    ctx.Employees.Add(std);
                }
                IList<Training> listOfTrainings = new List<Training>();

                listOfTrainings.Add(new Training() {TrainingId = Guid.NewGuid(), Name = "Math", Description = "101"});
                listOfTrainings.Add(new Training() {TrainingId = Guid.NewGuid(), Name = "Physics", Description = "101"});
                listOfTrainings.Add(new Training() {TrainingId = Guid.NewGuid(), Name = "Stats", Description = "102"});

                foreach (Training std in listOfTrainings)
                {
                    ctx.Trainings.Add(std);

                }

                ctx.SaveChanges();
            }
        }
    }
}