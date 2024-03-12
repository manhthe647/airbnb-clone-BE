namespace airbnb_clone_BE.Data.Entity
{
    public class PalaceCapacity
    {
        public int Id { get; set; }
        public int PalaceId { get; set; }
        public int GuestCount { get; set; }
        public int BedCount { get; set; }

        public int BedroomCount { get; set; }
    }
}
