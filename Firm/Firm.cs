class Firm
{
	static void Main()
	{
		int needhours = int.Parse(Console.ReadLine());
		int days = int.Parse(Console.ReadLine());
		int workers = int.Parse(Console.ReadLine());

		double workdays = days * 0.9;
		double hours = workdays * 8 * workers;
		double overtime = workers * workdays * 2;
		double workhours = overtime + hours;
		double totalhours = Math.Floor(workhours - needhours);
		if (totalhours > needhours)
		{
			Console.WriteLine($"Yes!{totalhours} hours left.");
		}
		else
		{
			totalhours = totalhours * -1;
			Console.WriteLine($"Not enough time!{totalhours} hours needed.");
		}
	}
}
