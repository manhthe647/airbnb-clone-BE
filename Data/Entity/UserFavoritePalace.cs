namespace airbnb_clone_BE.Data.Entity
{
    public class UserFavoritePalace
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PalaceId { get; set; }
    }
}
