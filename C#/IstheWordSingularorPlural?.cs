public class Program
{
	public static bool IsPlural(string word) => "s".Equals(word.Substring(word.Length - 1));
}
