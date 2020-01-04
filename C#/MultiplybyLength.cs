public class Program
{
	public static int[] MultiplyByLength(int[] arr)
	{
		int lengthofArray = arr.Length;
		
		for (int i = 0; i < lengthofArray; i ++)
		{
			arr[i] = arr[i] * lengthofArray;
		}
		
		return arr;
	}
}
