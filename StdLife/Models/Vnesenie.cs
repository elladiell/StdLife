using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StdLife.Models
{
    public class Vnesenie
    {
        public int VnesenieID { get; set; }
        public string Interier { get; set; }
        public string Value { get; set; }
        public string Adress { get; set; }
        public string Person { get; set; }
        public int StudentID { get; set; }
        public DateTime Date { get; set; }

    }
}