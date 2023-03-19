namespace PlamenkoMockGenerator
{
    internal class CustomerOrder
    {
        public long orderId { get; set; }
        public long orderedDate { get; set; }
        public long deliveredDate { get; set; }
        public string additionalOrderInfo { get; set; } = "-";
        public long paidDate { get; set; }
        public OrderItem orderItem { get; set; }  //Example: Spacva pelet,Biostar pelet,...
        public string orderQuantity { get; set; }  //Example: 2t, 3 palletes, 5m,....

    }
}
