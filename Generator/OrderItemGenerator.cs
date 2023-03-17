namespace PlamenkoMockGenerator.Generator
{
    internal class OrderItemGenerator
    {
        private string[] supply = { "Spacva pelet", "Biostar pelet" };

        public OrderItem GenerateOrderItem()
        {
            OrderItem orderItem = new OrderItem();
            Random rnd = new Random();
            int rndNum = rnd.Next(0, 10);
            if (rndNum < 5)
            {
                orderItem.itemName = supply[0];
                orderItem.itemId = 0;
                return orderItem;
            }
            else
            {
                orderItem.itemName = supply[1];
                orderItem.itemId = 1;
                return orderItem;
            }
        }
    }
}
