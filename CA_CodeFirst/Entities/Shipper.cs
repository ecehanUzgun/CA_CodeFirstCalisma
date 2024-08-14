namespace CA_CodeFirst.Entities
{
    public class Shipper
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Phone {  get; set; }
        public List<Order> Order { get; set; }

    }
}
