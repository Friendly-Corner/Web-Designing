using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friendly_Corner_backend.Models
{
   public class Booking
{
    public int BookingId { get; set; }
    public int RoomId { get; set; }
    public int UserId { get; set; }
    public DateTime BookingDate { get; set; }
    public TimeSpan BookingTime { get; set; }

    public  Room ?Room { get; set; }
    public  User? User { get; set; }
        public DateTime CreatedAt { get; internal set; }
        public DateTime StartTime { get; internal set; }
        public DateTime EndTime { get; internal set; }
    }
}