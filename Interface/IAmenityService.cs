using airbnb_clone_BE.Data.Entity;

namespace airbnb_clone_BE.Interface
{
    public interface IAmenityService
    {
        Task<List<Amenity>> GetAmenity();
    }
}
