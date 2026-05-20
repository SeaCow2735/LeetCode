// 1360. Number of Days Between Two Dates
// Given two dates, return the number of days between the two dates.
// The given dates are valid dates between the years 1971 and 2100.
public class Solution
{
    public int DaysBetweenDates(string date1, string date2)
    {
        DateTime d1 = ConvertStringIntoDateTime(date1);
        DateTime d2 = ConvertStringIntoDateTime(date2);

        return Math.Abs((d1 - d2).Days);
    }

    public DateTime ConvertStringIntoDateTime(string date)
    {
        int Year = int.Parse(date.Substring(0, 4));
        int Month = int.Parse(date.Substring(5, 2));
        int Day = int.Parse(date.Substring(8));

        return new DateTime(Year, Month, Day);
    }
}