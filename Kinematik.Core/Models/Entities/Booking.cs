namespace Kinematik.Core.Models.Entities
{
    public class Booking
    {
        public int ID { get; set; }
        public int SessionID { get; set; }
        public int SeatID { get; set; }
        public int UserID { get; set; }
        
        public Session Session { get; set; }
        public Seat Seat { get; set; }
        public User User { get; set; }
    }
}