using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StdLife.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Mail { get; set; }
        public string Passport { get; set; }
        public string Birth { get; set; }
    }
}