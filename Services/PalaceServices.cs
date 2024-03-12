using airbnb_clone_BE.Data;
using airbnb_clone_BE.Data.Entity;
using airbnb_clone_BE.Interface;
using airbnb_clone_BE.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace airbnb_clone_BE.Services
{
    public class PalaceServices : IPalaceService
    {
        private readonly DataContext _context;
        public PalaceServices(DataContext context)
        {
            _context = context;
        }

        public Task<List<PalaceDetailsVm>> Details()
        {
            throw new NotImplementedException();
        }

        public async Task<List<PalaceBasicVm>> GetDataPaging()
        {
            var result = await _context.Palaces.Select( x=> new PalaceBasicVm
            {
                Id = 1,
                Title = x.Title,
                AddressLine = x.AddressLine,
                City = x.City,
                District = x.District,
                Latitude = x.Latitude,
                Longitude = x.Longitude,
                Price = x.Price,
                //Star = x.Star
            }).ToListAsync();
            return result;
        }
    }
}
