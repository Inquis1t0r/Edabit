using System.Linq;
public class Program
    {
        public static int[] SortNumsAscending(int[] arr)
        {
          return (from i in arr orderby i ascending select i).ToArray();
        }
    }
