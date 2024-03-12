namespace airbnb_clone_BE.Data.Entity
{
    public class PalaceImages
    {
        public int Id { get; set; }
        public int PalaceId { get; set; }
        public string ImagePath { get; set; }
        public string Sort {  get; set; }
    }
}
