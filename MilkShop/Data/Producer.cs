namespace MilkShop.Data
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EIK { get; set; }
        public string Description { get; set; }
        public DateTime DateRegister { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
