using System.Collections.Generic;

namespace Kinematik.Core.Models.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}