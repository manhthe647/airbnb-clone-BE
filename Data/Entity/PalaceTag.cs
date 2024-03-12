using airbnb_clone_BE.Shared;

namespace airbnb_clone_BE.Data.Entity
{
    public class PalaceTag
    {
        public int Id { get; set; }
        public int PalaceId { get; set; }
        public PalaceTagEnum? Tag {  get; set; } 

    }
}
