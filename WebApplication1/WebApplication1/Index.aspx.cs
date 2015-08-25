using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
                var listOfAllEmployees =  from s in ctx.Employees
                            select s.Name;

                listOfAllEmployees = listOfAllEmployees.Distinct();

                var listOfLatestCourses = from s in ctx.Education  select s;
               listOfLatestCourses = listOfLatestCourses.Take(10);


                var employeeId = Guid.NewGuid();
                var listOfLatestCoursesForEmployee = ctx.Education.Where(s => s.EmployeeId == employeeId);
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



                IList<Education> listOfEducations = new List<Education>();
                var EmployeeId = (ctx.Employees.Where
                    (c => c.Name == "Vasya Pupkin").Select(c => c.EmployeeId)).FirstOrDefault();
                var TrainingId = (ctx.Trainings.Where(c => c.Name == "Math").Select(c => c.TrainingId)).FirstOrDefault();


                listOfEducations.Add(new Education() { EducationGuid = Guid.NewGuid(),EmployeeId = EmployeeId ,TrainingId = TrainingId});
                 EmployeeId = (ctx.Employees.Where
                   (c => c.Name == "Kolya Petrov").Select(c => c.EmployeeId)).FirstOrDefault();
                 TrainingId = (ctx.Trainings.Where(c => c.Name == "Stats").Select(c => c.TrainingId)).FirstOrDefault();


                listOfEducations.Add(new Education() { EducationGuid = Guid.NewGuid(), EmployeeId = EmployeeId, TrainingId = TrainingId });

                listOfEducations.Add(new Education() { EducationGuid = Guid.NewGuid(), EmployeeId = EmployeeId, TrainingId = TrainingId });
                EmployeeId = (ctx.Employees.Where
                  (c => c.Name == "Petya Vasechkin").Select(c => c.EmployeeId)).FirstOrDefault();
                TrainingId = (ctx.Trainings.Where(c => c.Name == "Physics").Select(c => c.TrainingId)).FirstOrDefault();


                listOfEducations.Add(new Education() { EducationGuid = Guid.NewGuid(), EmployeeId = EmployeeId, TrainingId = TrainingId });
                foreach (Education std in listOfEducations)
                {
                    ctx.Education.Add(std);

                }
                ctx.SaveChanges();
            }
        }

      

      

       
    }
}