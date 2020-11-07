using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HotelBooking.Models
{
    public class RoomDbInitializer : DropCreateDatabaseAlways<RoomContext>
    {
        protected override void Seed(RoomContext db)
        {
            db.Rooms.Add(new Room { RoomQuantity = 1, BedQuantity = 2, Rating = RatingEnum.Standart, Price = 1500 });
            db.Rooms.Add(new Room { RoomQuantity = 2, BedQuantity = 2, Rating = RatingEnum.Business, Price = 2000 });
            db.Rooms.Add(new Room { RoomQuantity = 3, BedQuantity = 2, Rating = RatingEnum.Lux, Price = 2500 });
            db.Rooms.Add(new Room { RoomQuantity = 3, BedQuantity = 3, Rating = RatingEnum.Business, Price = 2300 });
            base.Seed(db);
        }
    }
}