using System;

public class Program
{
    public static bool TimeForMilkAndCookies(int year, int month, int day)
    {
	DateTime compareDate = new DateTime(year, month, day);

	return compareDate.Day == 24 && compareDate.Month == 12;
    }
}
