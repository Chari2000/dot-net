using System;

public class Class2
{
	public Class2()
	{
		Console.WriteLine("Enter any two numbers:");
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int oper = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("1.Addition/n2.Substraction/n3.Multiplication/n4.Division");
			switch(oper)
            {
				case 1:
					Console.WriteLine("a+b="+(a+b));
				break;
				case 2:
					Console.WriteLine("a-b=" + (a - b));
				break;
				case 3:
					Console.WriteLine("a*b=" +( a * b));
				break;
				case 4:
					Console.WriteLine("a/b=" + (a / b));
				break;
			default:
				Console.WriteLine("You entered wrong input");
				break;
		}
	}
}
