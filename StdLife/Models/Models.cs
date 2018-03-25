using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StdLife.Models
{
        public class LoginModel
    {
        public event EventHandler Event;

        public string Name { get; set; }
            public string Password { get; set; }

        public int Property
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }

    public class RegisterModel
        {
           
            public string Name { get; set; }
            
            public string Password { get; set; } 

            public int Age { get; set; }
        }
    }
