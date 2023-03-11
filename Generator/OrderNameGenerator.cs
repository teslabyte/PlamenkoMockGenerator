namespace PlamenkoMockGenerator.Generator
{
    internal class OrderNameGenerator
    {
        private string[] supply = { "Spacva pelet", "Biostar pelet" };

        public string GenerateOrderName()
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(0, 10);
            if (rndNum < 5) return supply[0];
            else return supply[1];
        }
    }
}
