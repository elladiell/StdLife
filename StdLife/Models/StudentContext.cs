using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 

namespace StdLife.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student>Students { get; set; }
        public DbSet<Vnesenie>Vnesenies { get; set; }
    }

    public class StudentDbInitializer : DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext db)
        {
            db.Students.Add(new Student
            {
                Name = "Александр",
                Surname = "Иванов",
                MiddleName = "Олегович",
                Birth = "21.09.1995",
                Mail = "Ivanov95@ib.ru",
                Passport = "40.09.066374"
            });
            db.Students.Add(new Student
            {
                Name = "Ирина",
                Surname = "Воронина",
                MiddleName = "Георгиевна",
                Birth = "17.06.1992",
                Mail = "SolnyshkoYa@mail.ru",
                Passport = "40.06.341905"
            });
            db.Students.Add(new Student
            {
                Name = "Сати",
                Surname = "Милонян",
                MiddleName = "Гивиевна",
                Birth = "08.06.1996",
                Mail = "SatiSati@inbox.ru",
                Passport = "40.10.593061"
            });

            base.Seed(db);
        }
    }
}