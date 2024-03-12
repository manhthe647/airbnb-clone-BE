namespace airbnb_clone_BE.Data.Entity
{
    public class PalaceSecurity
    {
        public int Id { get; set; }
        public int PalaceId { get; set; }
        public bool hasCamera { get; set; }
        public bool hasSecurityStaff { get; set; }
    }
}
