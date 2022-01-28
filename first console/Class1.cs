using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Engter person age:");
		int age = Convert.ToInt32(ReadLine());
		if(age<0)
        {
			Console.WriteLine("Person is not eligible to vote.");
		}
		else
        {
			Console.WriteLine("Person is eligible to vote.");
		}
	}
}
