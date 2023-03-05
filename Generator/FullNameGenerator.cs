namespace PlamenkoMockGenerator.Generator
{
    internal class FullNameGenerator
    {
        string[] names;
        string[] surnames;
        public FullNameGenerator(string[] names, string[] surnames) {
            this.names = names;
            this.surnames = surnames;
        }

        public string GetRandomFullName()
        {
            Random rnd = new Random();
            int nameIndex = rnd.Next(0, names.Length);
            int surnameIndex = rnd.Next(0, surnames.Length);
            
            return names[nameIndex] + " " + surnames[surnameIndex];
        }
    }
}
