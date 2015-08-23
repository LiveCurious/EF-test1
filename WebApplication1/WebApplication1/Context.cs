using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EF_Code_First_Tutorials;
using test;


namespace test
    {

        public class Context : DbContext
        {
            public Context()
                : base("MyInterview")
            {
              Database.SetInitializer<Context>(new MyInterviewDBInitializer());
            }

            public DbSet<Employee> Employees { get; set; }
            public DbSet<Training> Trainings { get; set; }
         

        }
    }
        
