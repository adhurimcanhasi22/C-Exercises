﻿class NumberToWord
{
	static void Main()
	{
		int number = int.Parse(Console.ReadLine());
		if (number == 0)
		{
			Console.WriteLine("Zero");
		}
		else if (number == 1)
		{
			Console.WriteLine("One");
		}
		else if (number == 2)
		{
			Console.WriteLine("Two");
		}
		else if (number == 3)
		{
			Console.WriteLine("Three");
		}
		else if (number == 4)
		{
			Console.WriteLine("Four");
		}
		else if (number == 5)
		{
			Console.WriteLine("Five");
		}
		else if (number == 6)
		{
			Console.WriteLine("Six");
		}
		else if (number == 7)
		{
			Console.WriteLine("Seven");
		}
		else if (number == 8)
		{
			Console.WriteLine("Eight");
		}
		else if (number == 9)
		{
			Console.WriteLine("Nine");
		}
		else if (number > 9)
		{
			Console.WriteLine("Number too big");
		}
		else if (number < 0)
		{
			Console.WriteLine("Number too small");
		}
	}
}