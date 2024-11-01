class VolleyBall
{
	static void Main()
	{
		string year = Console.ReadLine().ToLower();
		int h = int.Parse(Console.ReadLine());
		int w = int.Parse(Console.ReadLine());

		int sofia = 48 - w;
		double playsofia = (3.0 * sofia / 4) + (2.0 * h / 3);
		double total = w + playsofia;

		switch (year)
		{
			case "normal":
				{
					Console.WriteLine(Math.Floor(total));
				}
				break;
			case "leap":
				{
					Console.WriteLine(Math.Floor(total * 15 / 100 + total));
				}
				break;
		}
	}
}