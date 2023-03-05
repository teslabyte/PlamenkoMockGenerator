namespace PlamenkoMockGenerator.Generator
{
    internal class CustomerGenerator
    {
        long customerId;
        string[] allStreets;
        string[] allNames;
        string[] allSurnames;

        public CustomerGenerator(long customerId, string[] allStreets, string[] allNames, string[] allSurnames) {
            this.customerId = customerId;
            this.allSurnames = allSurnames;
            this.allNames = allNames;
            this.allStreets = allStreets;
        }
        public Customer GenerateCustomer()
        {
            AddressGenerator adgen = new AddressGenerator(allStreets);
            FullNameGenerator fnmgen = new FullNameGenerator(allNames, allSurnames);
            PhoneNumberGenerator pgen = new PhoneNumberGenerator();
            CustomerAdditionalInfoGenerator cadigen = new CustomerAdditionalInfoGenerator();
            OrderDateGenerator odgen = new OrderDateGenerator();
            Random rnd = new Random();

            Customer customer = new Customer();
            customer.customerId = customerId + 1;
            customer.customerName = fnmgen.GetRandomFullName();
            customer.customerAddress = adgen.GenerateRandomAddress();
            customer.customerPhoneNumber = pgen.GetRandomPhoneNumber();
            customer.customerAdditionalInfo = cadigen.GenerateCustomerAdditionalInfo();

            int orderNum = rnd.Next(1, 5);
            List<CustomerOrder> orders = new List<CustomerOrder>();
            for (int j = 0; j < orderNum; j++)
            {
                string[] dates = odgen.GenerateOrderDates();
                CustomerOrder customerOrder = new CustomerOrder();
                customerOrder.orderedDate = dates[0];
                customerOrder.deliveredDate = dates[1];
                orders.Add(customerOrder);
            }

            customer.customerOrders = orders;

            return customer;
        }
    }
}
