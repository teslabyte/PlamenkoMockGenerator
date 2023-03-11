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

            string paidDate = GenerateDate(ref day, ref month, ref year);

            string deliveredDate = GenerateDate(ref day, ref month, ref year);

            int del = rnd.Next(1, 11);
            if(del > 8)
            {
                if(del == 9) return new string[] { orderedDate, "-", paidDate };
                else return new string[] { orderedDate, "-", "-" };
            }
            else
            {
                return new string[] { orderedDate, deliveredDate , paidDate};
            }
        }
    
        string GenerateDate(ref int day, ref int month, ref int year)
        {
            Random rnd = new Random();
            day = day + rnd.Next(1, 7);
            if (day > 30)
            {
                day = day - 30;
                month = month + 1;
            }
            if (month > 12)
            {
                month = 1;
                year = year + 1;
            }
            return day + "." + month + "." + year;
        }
    }
}
