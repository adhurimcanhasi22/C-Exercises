class Points
{
	static void Main()
	{
		int h = int.Parse(Console.ReadLine());
		int x = int.Parse(Console.ReadLine());
		int y = int.Parse(Console.ReadLine());

		bool outrec1 = (x < 0 || x > 3 * h) || (y < 0 || y > h);
		bool outrec2 = (x < h || x > 2 * h) || (y < h || y > 4 * h);

		bool inrec1 = (x > 0 && x < 3 * h) && (y > 0 && y < h);
		bool inrec2 = (x > h && x < 3 * h) && (y > h && y < 4 * h);

		bool border = (x > h && x < 3 * h) && y == h;

		if (outrec1 && outrec2)
		{
			Console.WriteLine("outside");
		}
		else if (inrec1 || inrec2 || border)
		{
			Console.WriteLine("inside");
		}
		else
		{
			Console.WriteLine("border");
		}

	}
}