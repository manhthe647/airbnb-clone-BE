using System.ComponentModel.DataAnnotations;

namespace airbnb_clone_BE.Data.Entity
{
    public class PalaceAmenity
    {
        [Key]
        public int Id { get; set; }
        public int PalaceId { get; set; }
        public int AmenityId { get; set; }

    }
}
