namespace airbnb_clone_BE.ViewModel
{
    public class PalaceBasicVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? AddressLine { get; set; }
        public double Price { get; set; }
        public int? Star { get; set; }
    }
}
