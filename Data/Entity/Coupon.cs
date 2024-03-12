namespace airbnb_clone_BE.Data.Entity
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string CouponDescription { get; set; }
        public int TimesUsed { get; set; }
        public int MaxUsage { get; set; }
        public decimal DiscountValue { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateExpired { get; set; }

    }
}
