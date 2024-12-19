using System;

public class DateCalculator
{
    public static int DaysBetweenDates(DateTime date1, DateTime date2)
    {
        return (date2 - date1).Days;
    }
}