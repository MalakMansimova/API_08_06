namespace ProductAPI.Dtos.Products
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int RestaurantId { get; set; }
    }
}
