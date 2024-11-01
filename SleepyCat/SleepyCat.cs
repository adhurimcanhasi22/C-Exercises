class Cat
{
	static void Main()
	{

		int holidays = int.Parse(Console.ReadLine());
		int days = 365;
		int tomtime = 30000;
		int gametime = ((days - holidays) * 63) + holidays * 127;
		int norm = tomtime - gametime;
		int hours = norm / 60;
		int minutes = norm % 60;
		if (norm >= 0)
		{
			Console.WriteLine("Tom sleeps well");
			Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
		}
		else
		{
			hours = hours * -1;
			minutes = minutes * -1;
			Console.WriteLine("Tom will run away");
			Console.WriteLine($"{hours} hours and {minutes} minutes more for play");

		}

	}
}
