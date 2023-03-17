namespace PlamenkoMockGenerator
{
    internal class CustomerOrder
    {
        public long orderId { get; set; }
        public string orderedDate { get; set; }
        public string deliveredDate { get; set; }
        public string additionalOrderInfo { get; set; } = "-";
        public string paidDate { get; set; }
        public OrderItem orderItem { get; set; }
        //string orderName { get; set; }  //Example: Spacva pelet,Biostar pelet,...
        public string orderQuantity { get; set; }  //Example: 2t, 3 palletes, 5m,....

    }
}
