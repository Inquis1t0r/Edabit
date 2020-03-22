using System; 

public class Program 
{
    public static long CalculateExponent(long number, long exponent) => Convert.ToInt64(Math.Pow(Convert.ToDouble(number), Convert.ToDouble(exponent)));
}
