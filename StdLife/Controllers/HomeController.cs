using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StdLife.Models;
namespace StdLife.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();


        public ActionResult Index()
        {

            var students = db.Students;
            ViewBag.Students = students;
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult Add(int id)
        {
            ViewBag.StudentId = id;
            return View();
        }

        [Authorize]
        [HttpPost]
        public string Add(Vnesenie vnesenie)
        {
            vnesenie.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Vnesenies.Add(vnesenie);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Студент " + vnesenie.Person + " заплатил " + vnesenie.Value + ", проживает по адресу: " + vnesenie.Adress + ". Сегодняшняя дата: " + vnesenie.Date + ". В помещении есть: " + vnesenie.Interier + ".";
        }


        public string About()
        {
            string result = "Вы не авторизованы";
            if (User.Identity.IsAuthenticated)
            {
                result = "Ваш логин: " + User.Identity.Name;
            }
            return result;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}