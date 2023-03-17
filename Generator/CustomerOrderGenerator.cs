namespace PlamenkoMockGenerator.Generator
{
    internal class CustomerOrderGenerator
    {
        public List<CustomerOrder> GenerateCustomerOrders(long totalOrders)
        {
            List<CustomerOrder> customerOrders = new List<CustomerOrder>();

            OrderDateGenerator odgen = new OrderDateGenerator();
            OrderItemGenerator oigen = new OrderItemGenerator();
            OrderQuantityGenerator oqgen = new OrderQuantityGenerator();

            for (int i = 0; i < totalOrders; i++)
            {
                CustomerOrder order = new CustomerOrder();
                order.orderId = i+1;

                string[] dates = odgen.GenerateOrderDates();

                order.orderedDate = dates[0];
                order.deliveredDate = dates[1];
                order.paidDate = dates[2];

                order.orderItem = oigen.GenerateOrderItem();
                order.orderQuantity = oqgen.GenerateOrderQuantity();

                customerOrders.Add(order);
            }

            return customerOrders;
        }
    }
}
