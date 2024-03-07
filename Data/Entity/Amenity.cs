using System.ComponentModel.DataAnnotations;

namespace airbnb_clone_BE.Data.Entity
{
    public class Amenity
    {
        [Key]
        public int Id { get; set; }
        public string AmentityName { get; set; }
        public string? Icon { get; set;}
    }
}
