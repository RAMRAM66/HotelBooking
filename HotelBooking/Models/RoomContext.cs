using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class RoomContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}