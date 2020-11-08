using HotelBooking.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease.Activities;

namespace HotelBooking.Controllers
{
    public class HomeController : Controller
    {
        RoomContext db = new RoomContext();
        public ActionResult Index()
        {
            IEnumerable<Room> rooms = db.Rooms;
            ViewBag.Rooms = rooms;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.RoomId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            order.Date = DateTime.Now;
            db.Orders.Add(order);
            db.SaveChanges();
            return "Спасибо, " + order.Person + ", за бронирование!";
        }
        public string Sum(double a, double b)
        {
            double s = a * b;
            return $"<h2>Сумма чисел {a} и {b} равна {s}</h2>";
        }
        public FileResult GetFile()
        {
            string filePath = Server.MapPath("~/Files/Price.xlsx");
            string fileType = "application/xlsx";
            string fileName = "Price.xlsx";
            return File(filePath, fileType, fileName);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}