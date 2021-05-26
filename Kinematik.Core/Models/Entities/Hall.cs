using System.Collections.Generic;

namespace Kinematik.Core.Models.Entities
{
    public class Hall
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public HallType HallType { get; set; }
        
        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}