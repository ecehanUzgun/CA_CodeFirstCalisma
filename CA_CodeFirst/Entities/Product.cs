namespace CA_CodeFirst.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit {  get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel { get; set;}
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
