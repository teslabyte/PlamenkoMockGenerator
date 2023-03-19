namespace PlamenkoMockGenerator.Generator
{
    internal class OrderDateGenerator
    {
        public long[] GenerateOrderDates() {
            Random rnd = new Random();
            int day = rnd.Next(1, 30);
            int month = rnd.Next(1, 12);
            int year = rnd.Next(2020, 2023);

            long orderedDate = (long) (new DateTime(year, month, day, rnd.Next(0, 24), rnd.Next(0, 60), rnd.Next(0, 60), rnd.Next(0, 1000)) - new DateTime(1970, 1, 1)).TotalMilliseconds;

            long paidDate = (long) (GenerateDate(ref day, ref month, ref year) - new DateTime(1970, 1, 1)).TotalMilliseconds;

            long deliveredDate = (long) (GenerateDate(ref day, ref month, ref year) - new DateTime(1970, 1, 1)).TotalMilliseconds;

            int del = rnd.Next(1, 11);
            if(del > 8)
            {
                if(del == 9) return new long[] { orderedDate, -1, paidDate };
                else return new long[] { orderedDate, -1, -1 };
            }
            else
            {
                return new long[] { orderedDate, deliveredDate , paidDate};
            }
        }
    
        DateTime GenerateDate(ref int day, ref int month, ref int year)
        {
            Random rnd = new Random();
            day = day + rnd.Next(1, 7);
            if (day > 28)
            {
                day = day - 28;
                month = month + 1;
            }
            if (month > 12)
            {
                month = 1;
                year = year + 1;
            }

;            return new DateTime(year, month, day, rnd.Next(0, 24), rnd.Next(0, 60), rnd.Next(0, 60), rnd.Next(0, 1000));
        }
    }
}
