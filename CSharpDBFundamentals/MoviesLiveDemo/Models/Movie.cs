namespace Models
{
    public class Movie
    {
        public int Id  { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int YearOfRelease { get; set; }
        public float Rating { get; set; }
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }

    }
}
