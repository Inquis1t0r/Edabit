using System;
using System.Linq;
public class Program 
{
    public static double[] FindMinMax(double[] values) 
    {
			double[] result = new double [values.Min(), values.Max()];
			return result;
    }
}
