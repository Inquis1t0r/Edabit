using System;

public class Program
{
    public static string RemoveFirstLast(string str) => (str.Length <= 2)?str:str.Substring(1, str.Length -2);
}
