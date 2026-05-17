//1185. Day of the Week
//Given a date, return the corresponding day of the week for that date.
// The input is given as three integers representing the day, month and year respectively.
// The output should be one of the following strings: "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", or "Saturday".
// My Solution (Best Solution for run time)
public class Solution
{
    public string DayOfTheWeek(int day, int month, int year)
    {
        string[] days =
        {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        int[] months =
        {
            31,28,31,30,31,30,
            31,31,30,31,30,31
        };

        int totalDays = 4;

        for (int y = 1971; y < year; y++)
        {
            totalDays += IsLeap(y) ? 366 : 365;
        }

        for (int m = 1; m < month; m++)
        {
            totalDays += months[m - 1];

            if (m == 2 && IsLeap(year))
            {
                totalDays += 1;
            }
        }

        totalDays += day;

        return days[totalDays % 7];
    }

    public bool IsLeap(int year)
    {
        return year % 400 == 0 ||
              (year % 4 == 0 && year % 100 != 0);
    }
}