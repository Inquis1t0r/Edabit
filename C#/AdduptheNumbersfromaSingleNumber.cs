public class Program 
{
    public static int AddUp(int num) 
    {
			var sum = 0;
			
			for(var i = 1; i <= num; i++){
				sum += i;
			}
			
			return sum;
    }
}
