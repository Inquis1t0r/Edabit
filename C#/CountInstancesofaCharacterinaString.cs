using System.Linq;

public class Program 
{
    public static int CharCount(char myChar, string str) => str.Count(c => c == myChar);
}
