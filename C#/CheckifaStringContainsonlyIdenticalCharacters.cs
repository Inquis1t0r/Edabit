public class Program
{
    public static bool isIdentical(string str)
    {
			return str.Distinct().Count() == 1;
    }
}
