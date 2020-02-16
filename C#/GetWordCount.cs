using System;

public class Program
    {
        public static int CountWords(string str)
        {
            char[] delimiters = new char[] {' ', '\r', '\n' };
						return str.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length; 
        }
    }
