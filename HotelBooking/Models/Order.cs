using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Person { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime BookingBegin { get; set; }
        public DateTime BookingEnd { get; set; }
        public int RoomId { get; set; }
    }
}