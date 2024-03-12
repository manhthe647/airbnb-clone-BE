using airbnb_clone_BE.ViewModel;

namespace airbnb_clone_BE.Interface
{
    public interface IPalaceService
    {
        Task<List<PalaceBasicVm>> GetDataPaging();
        Task<List<PalaceDetailsVm>> Details();
    }
}
