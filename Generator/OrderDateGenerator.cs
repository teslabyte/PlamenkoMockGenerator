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
                day = day + rnd.Next(1, 10);
                if(day > 30)
                {
                    day = day - 30;
                    month = month + 1;
                }
                if(month > 12)
                {
                    month = 1;
                    year = year + 1;
                }
                string deliveredDate = day + "." + month + "." + year;
                return new string[] { orderedDate, deliveredDate };
            }
        }
    }
}
