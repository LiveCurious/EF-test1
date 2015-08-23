using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using test;

namespace test
{
    public class MyInterviewDBInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);
              IList<Employee> listOfEmployees = new List<Employee>();

              listOfEmployees.Add(new Employee() { EmployeeId = Guid.NewGuid(), Name = "Vasya Pupkin", DateOfBith = new DateTime(1991, 12, 12) });
              listOfEmployees.Add(new Employee() { EmployeeId = Guid.NewGuid(), Name = "Petya Vasechkin", DateOfBith = new DateTime(1992, 03, 23) });
              listOfEmployees.Add(new Employee() { EmployeeId = Guid.NewGuid(), Name = "Kolya Petrov", DateOfBith = new DateTime(1993, 04, 04) });

            foreach (Employee std in listOfEmployees)
            {
                context.Employees.Add(std);
            }
            IList<Training> listOfTrainings = new List<Training>();

            listOfTrainings.Add(new Training() { TrainingId = Guid.NewGuid(), Name = "Math", Description = "101" });
            listOfTrainings.Add(new Training() { TrainingId = Guid.NewGuid(), Name = "Physics", Description = "101" });
            listOfTrainings.Add(new Training() { TrainingId = Guid.NewGuid(), Name = "Stats", Description = "102" });

            foreach (Training std in listOfTrainings)
            {
                context.Trainings.Add(std);

            }
            context.SaveChanges();
         
        }
    }
}