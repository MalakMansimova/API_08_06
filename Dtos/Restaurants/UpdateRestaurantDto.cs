namespace ProductAPI.Dtos.Restaurants
{
    public class UpdateRestaurantDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
    }
}
