using System;

public class Program
{
	public static int FlipIntBool(int ib)
	{	
		return Int32.TryParse(ib.ToString.Replace('0','*').Replace('1','0').Replace('*','1'));
	}
}
