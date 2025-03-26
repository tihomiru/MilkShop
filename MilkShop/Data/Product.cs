namespace MilkShop.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeProductId { get; set; }
        public TypeProduct TypeProducts { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public TypePackages Packages { get; set; }
        public string Description { get; set; }
        public int ProducerId { get; set; }
        public Producer Producers { get; set; }
        public DateTime DateRegister { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
