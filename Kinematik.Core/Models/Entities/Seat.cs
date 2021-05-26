using System.Collections.Generic;

namespace Kinematik.Core.Models.Entities
{
    public class Seat
    {
        public int ID { get; set; }
        public int HallID { get; set; }
        public SeatType SeatType { get; set; }
        
        public Hall Hall { get; set; }
        
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}