namespace airbnb_clone_BE.Data.Entity
{
    public class PalaceBathroom
    {
        public int Id { get; set; }
        public int PalaceId { get; set; }
        public int PrivateClosedBathroom {  get; set; } //riêng và khép kín
        public int PrivateBathroom { get; set; }
        public int sharedBathroom { get; set; }
    }
}
