using HotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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