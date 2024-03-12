namespace airbnb_clone_BE.Data.Entity
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid FromUser { get; set; }
        public Guid ToUser { get; set; }
    }
}
