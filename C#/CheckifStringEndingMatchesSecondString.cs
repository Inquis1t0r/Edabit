public class Program
{
    public static bool CheckEnding(string str1, string str2) => str1.Substring(str1.Length - str2.Length).Equals(str2);
}
