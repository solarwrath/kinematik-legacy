namespace Kinematik.Core.Models.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public int FilmID { get; set; }
        public int UserID { get; set; }
        public string Text { get; set; }
        
        public Film Film { get; set; }
        public User User { get; set; }
    }
}