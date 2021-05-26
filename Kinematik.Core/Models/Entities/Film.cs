using System;
using System.Collections.Generic;

namespace Kinematik.Core.Models.Entities
{
    public class Film
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int GenreID { get; set; }
        public int Duration { get; set; }
        public DateTime AirStartDate { get; set; }
        public DateTime AirEndDate { get; set; }
        public GenreType Genre { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}