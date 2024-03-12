namespace airbnb_clone_BE.Data.Entity
{
    public class PalaceImage
    {
        public int Id { get; set; }
        public int PalaceId { get; set; }
        public string ImagePath { get; set; }
        public string Sort {  get; set; }
    }
}
