class numbers
{
	static void Main()
	{
		int num = int.Parse(Console.ReadLine());
		if (num < 100)
		{
			Console.WriteLine("Below 100");
		}
		else if (num >= 100 && num <= 200)
		{
			Console.WriteLine("Number between 100 and 200 ");

		}
		else if (num > 200)
		{
			Console.WriteLine("Number greater than 200");
		}
	}
}