namespace PlamenkoMockGenerator
{
    internal class Customer
    {
        public long customerId { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string customerPhoneNumber { get; set; }
        public List<CustomerOrder> customerOrders { get; set; }
        public string customerAdditionalInfo { get; set; }

        public bool delivered { get; set; } = true;
        public bool active { get; set; } = true;
    }
}
