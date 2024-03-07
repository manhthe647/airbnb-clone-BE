using airbnb_clone_BE.Data;
using airbnb_clone_BE.Data.Entity;
using airbnb_clone_BE.Interface;
using Microsoft.EntityFrameworkCore;

namespace airbnb_clone_BE.Services
{
    public class AmenityServices : IAmenityService
    {
        private readonly DataContext _context;
        public AmenityServices(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Amenity>> GetAmenity()
        {
            return await _context.Amenities.ToListAsync();
        }
    }
}
