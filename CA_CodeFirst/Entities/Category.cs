namespace CA_CodeFirst.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set;}
    }
}
