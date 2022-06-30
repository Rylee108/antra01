// See https://aka.ms/new-console-template for more information

using System;
public class Birthday
{
    public static void Main()
    {
        DateTime QNTime = DateTime.ParseExact(value.QN.Substring(0, 14), "yyyyMMddHHmmss", null);
        DateTime LocalTime = DateTime.Now;
        TimeSpan days = (QNTime - LocalTime);
        double day = days.TotalDays;

        int daysToNextAnniversity = 10000 - (day % 10000);
    }
}
