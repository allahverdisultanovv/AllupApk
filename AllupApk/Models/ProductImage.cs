namespace AllupApk.Models
{
    public class ProductImage : BaseEntity
    {
        public string ImageURL { get; set; }
        public bool? IsPrimary { get; set; }
        public Product Product { get; set; }
    }
}
