public class Program
{
    public static int Factorial(int num) => (num == 1) ? 1 : num * Factorial(num - 1);
}
