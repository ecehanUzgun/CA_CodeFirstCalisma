namespace CA_CodeFirst.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        //Foreign Key
        public int ShipVia { get; set; }
        public Shipper Shipper { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
    }
}
