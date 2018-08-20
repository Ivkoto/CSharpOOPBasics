namespace E05_DateModifier
{
    using System;
    using System.Globalization;

    public class DateModifier
    {
        public static double GetDateDifference(string firstDate, string secondDate)
        {
            var dateOne = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var dateTwo = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (dateOne > dateTwo)
            {
                return GetDateDifference(secondDate, firstDate);
            }
            return (dateTwo - dateOne).Days;
        }
    }
}
