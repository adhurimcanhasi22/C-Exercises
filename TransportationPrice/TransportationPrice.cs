class transportation
{
	static void Main()
	{
		int k = int.Parse(Console.ReadLine());
		string daynight = Console.ReadLine();
		double price = 0;
		double taxirate = 0;

		if (k < 20 && k > 0)
		{
			if (daynight == "day")
			{
				taxirate = 0.79;
			}
			else
			{
				taxirate = 0.90;
			}
			Console.WriteLine(k * taxirate + 0.70);
		}
		else if (k < 100)
		{
			Console.WriteLine(k * 0.09);
		}
		else
		{
			Console.WriteLine(k * 0.06);
		}

	}
}