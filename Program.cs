using System.Text.Encodings.Web;
using System.Text.Json;
using PlamenkoMockGenerator;
using PlamenkoMockGenerator.Generator;

Console.WriteLine("Enter how many mock customers do you want:");

int mockNumber = Convert.ToInt32(Console.ReadLine());

if (mockNumber < 0 || mockNumber > 10000) return;

string[] allNames = File.ReadAllLines(Environment.CurrentDirectory + "\\Data\\names.txt");
string[] allSurnames = File.ReadAllLines(Environment.CurrentDirectory + "\\Data\\surnames.txt");
string[] allStreets = File.ReadAllLines(Environment.CurrentDirectory + "\\Data\\streets.txt");

List<Customer> customers = new List<Customer>();
List<CustomerOrder> orders = new List<CustomerOrder>();

CustomerGenerator cgen = new CustomerGenerator(allStreets, allNames, allSurnames);
CustomerOrderGenerator cogen= new CustomerOrderGenerator();

orders = cogen.GenerateCustomerOrders(mockNumber * 12);
customers = cgen.GenerateCustomers(mockNumber);

//Distribute orders to customers
Random rnd = new Random();
for(int i = 0; i < orders.Count; i++)
{
    int rndCustomerId = rnd.Next(0, customers.Count);
    customers[rndCustomerId].customerOrders.Add(orders[i]);
}

foreach(Customer customer in customers)
{
    foreach(CustomerOrder cOrders in customer.customerOrders)
    {
        if (cOrders.deliveredDate == -1) customer.delivered = false;
    }
}

FileInfo mockCustomerFile = new FileInfo(Environment.CurrentDirectory + "\\Mock Data\\mock_customers.json");
mockCustomerFile.Directory.Create();

File.WriteAllText(mockCustomerFile.FullName, JsonSerializer.Serialize(customers, new JsonSerializerOptions
{
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    WriteIndented = true
}));