namespace PlamenkoMockGenerator.Generator
{
    internal class CustomerGenerator
    {
        string[] allStreets;
        string[] allNames;
        string[] allSurnames;

        public CustomerGenerator(string[] allStreets, string[] allNames, string[] allSurnames) {
            this.allSurnames = allSurnames;
            this.allNames = allNames;
            this.allStreets = allStreets;
        }
        public List<Customer> GenerateCustomers(long mockNumber)
        {
            AddressGenerator adgen = new AddressGenerator(allStreets);
            FullNameGenerator fnmgen = new FullNameGenerator(allNames, allSurnames);
            PhoneNumberGenerator pgen = new PhoneNumberGenerator();
            CustomerAdditionalInfoGenerator cadigen = new CustomerAdditionalInfoGenerator();
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < mockNumber; i++)
            {
                Customer customer = new Customer();
                customer.customerId = i + 1;
                customer.customerName = fnmgen.GetRandomFullName();
                customer.customerAddress = adgen.GenerateRandomAddress();
                customer.customerPhoneNumber = pgen.GetRandomPhoneNumber();
                customer.customerAdditionalInfo = cadigen.GenerateCustomerAdditionalInfo();
                customer.customerOrders = new List<CustomerOrder>();
                customers.Add(customer);
            }

            return customers;
        }
    }
}
