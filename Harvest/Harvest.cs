class Harvest
{
	static void Main()
	{
		int area = int.Parse(Console.ReadLine());
		double grapem2 = double.Parse(Console.ReadLine());
		int wine = int.Parse(Console.ReadLine());
		int workers = int.Parse(Console.ReadLine());

		double grapeskg = area * grapem2 * 0.4;
		double liters = grapeskg / 2.5;
		double product = liters - wine;
		double workerwine = product / workers;
		if (liters < wine)
		{
			product = product * -1;
			Console.WriteLine("It will be a tough winter");
			Console.WriteLine($"{Math.Round(product, 0)} more liters wine needed");
		}
		else
		{
			Console.WriteLine($"Good harvest this year!Total wine:{Math.Round(liters, 1)} liters.");
			Console.WriteLine($"{Math.Round(product, 0)} liters left.{Math.Round(workerwine, 1)} liters per person ");
		}
	}
}