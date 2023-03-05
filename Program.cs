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

for(int i = 0; i < mockNumber; i++)
{

    CustomerGenerator cgen = new CustomerGenerator(i, allStreets, allNames, allSurnames);

    customers.Add(cgen.GenerateCustomer());
   
}

FileInfo mockFile = new FileInfo(Environment.CurrentDirectory + "\\Mock Data\\mock.json");
mockFile.Directory.Create();

File.WriteAllText(mockFile.FullName, JsonSerializer.Serialize(customers, new JsonSerializerOptions
{
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    WriteIndented = true
}));