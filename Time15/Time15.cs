class time
{
	static void Main()
	{
		int h = int.Parse(Console.ReadLine());
		int m = int.Parse(Console.ReadLine());
		int time = m + 15;
		if (h < 23 && h >= 0)
		{
			if (time > 59)
			{
				h++;
				time -= 60;
				Console.WriteLine(h + ":" + "0" + time);
			}
			else if (time < 60)
			{

				Console.WriteLine(h + ":" + time);
			}
		}
		else if (time > 59)
		{
			time -= 60;
			Console.WriteLine("0:" + time);
		}

	}
}