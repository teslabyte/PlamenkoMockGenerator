namespace PlamenkoMockGenerator.Generator
{
    internal class AddressGenerator
    {
        string[] streets;
        public AddressGenerator(string[] streets) {
            this.streets = streets;
        }

        public string GenerateRandomAddress()
        {
            Random rnd = new Random();
            int streetIndex = rnd.Next(0, streets.Length);
            int streetNumber = rnd.Next(1, 150);

            return streets[streetIndex] + " " + streetNumber;
        }
    }
}
