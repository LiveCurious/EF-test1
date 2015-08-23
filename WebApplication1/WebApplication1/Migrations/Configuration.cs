using System.Collections.Generic;
using test;

namespace EF_Code_First_Tutorials.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<test.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(test.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            IList<Employee> listOfEmployees = new List<Employee>();

            listOfEmployees.Add(new Employee() { EmployeeId = new Guid(), Name = "Vasya Pupkin", DateOfBith = new DateTime(1991, 12, 12) });
            listOfEmployees.Add(new Employee() { EmployeeId = new Guid(), Name = "Petya Vasechkin", DateOfBith = new DateTime(1992, 03, 23) });
            listOfEmployees.Add(new Employee() { EmployeeId = new Guid(), Name = "Kolya Petrov", DateOfBith = new DateTime(1993, 04, 04) });

            foreach (Employee std in listOfEmployees)
                context.Employees.AddOrUpdate(std);

            IList<Training> listOfTrainings = new List<Training>();

            listOfTrainings.Add(new Training() { TrainingId = new Guid(), Name = "Math", Description = "101" });
            listOfTrainings.Add(new Training() { TrainingId = new Guid(), Name = "Physics", Description = "101" });
            listOfTrainings.Add(new Training() { TrainingId = new Guid(), Name = "Stats", Description = "102" });

            foreach (Training std in listOfTrainings)
                context.Trainings.AddOrUpdate(std);

        
            /*//Querying with LINQ to Entities 
    using (var context = new SchoolDBEntities())
    {
        var L2EQuery = context.Students.where(s => s.StudentName == "Bill");
        
        var student = L2EQuery.FirstOrDefault<Student>();
*/

           // listOfEducation.Add(new Education(){EmployeeId =  });

            base.Seed(context);
        }
    }
}
