namespace PlamenkoMockGenerator.Generator
{
    internal class OrderQuantityGenerator
    {
        private string[] quantityUnit = { "t", "paleta" };

        public string GenerateOrderQuantity()
        {
            Random rnd = new Random();
            int quantity = rnd.Next(1, 6);
            int unit = rnd.Next(0, 3);
            if(unit != 2) return quantity + quantityUnit[0];
            else return quantity + " " + quantityUnit[1];
        }
    }
}
