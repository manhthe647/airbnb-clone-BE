namespace airbnb_clone_BE.Data.Entity
{
    public class Review
    {
        public int Id { get; set; }
        public int PalaceId { get; set; }
        public int UserId { get; set; }
        public int? Star { get; set; }
        public string? Comment { get; set; }
    }
}
