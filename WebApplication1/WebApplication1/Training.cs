using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using test;

namespace test
{
    public class Training
    {
        public Training()
        {

        }

        public Guid TrainingId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}