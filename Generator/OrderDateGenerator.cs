namespace PlamenkoMockGenerator.Generator
{
    internal class OrderDateGenerator
    {
        public string[] GenerateOrderDates() {
            Random rnd = new Random();
            int day = rnd.Next(1, 30);
            int month = rnd.Next(1, 12);
            int year = rnd.Next(2020, 2023);
            string orderedDate = day + "." + month + "." + year;

            int del = rnd.Next(1, 10);
            if(del > 8)
            {
                return new string[] { orderedDate, "-" };
            }
            else
            {
                day = rnd.Next(day, 30);
                month= rnd.Next(month, 12);
                year = rnd.Next(year, 2024);
                string deliveredDate = day + "." + month + "." + year;
                return new string[] { orderedDate, deliveredDate };
            }
        }
    }
}
