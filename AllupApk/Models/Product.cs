namespace AllupApk.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }



        //relational
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public List<ProductImage> productImages { get; set; }
    }
}
