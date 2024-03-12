using airbnb_clone_BE.Shared;

namespace airbnb_clone_BE.Data.Entity
{
    public class PalaceTags
    {
        public int Id { get; set; }
        public int PalaceId { get; set; }
        public PalaceTagEnum PalaceTag {  get; set; } 

    }
}
