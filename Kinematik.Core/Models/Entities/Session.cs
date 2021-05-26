using System;
using System.Collections.Generic;

namespace Kinematik.Core.Models.Entities
{
    public class Session
    {
        public int ID { get; set; }
        public int FilmID { get; set; }
        public int HallID { get; set; }
        public DateTime StartTime { get; set; }
        
        public Film Film { get; set; }
        public Hall Hall { get; set; }
        
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}