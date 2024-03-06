namespace airbnb_clone_BE.Entities
{
    public class Palace
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public bool isActive { get; set; }
    }
}
