using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public enum RatingEnum
    {
        Standart,
        Business,
        Lux
    }
    public class Room
    {
        public int Id { get; set; }
        public int RoomQuantity { get; set; }
        public int BedQuantity { get; set; }
        public RatingEnum Rating { get; set; }
        public decimal Price { get; set; }
    }
}