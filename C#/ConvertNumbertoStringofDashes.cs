using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static string Go(int num)
    {
			return string.Concat(Enumerable.Repeat("-", num));
    }
}
