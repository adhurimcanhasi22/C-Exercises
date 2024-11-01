class figures
{
	static void Main()
	{
		string figure = Console.ReadLine();
		if (figure == "square")
		{
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine(Math.Round(a * a, 3));
		}
		else if (figure == "rectangle")
		{
			double c = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			Console.WriteLine(Math.Round(c * b, 3));
		}
		else if (figure == "triangle")
		{
			double h = double.Parse(Console.ReadLine());
			double B = double.Parse(Console.ReadLine());
			Console.WriteLine(Math.Round((h * B) / 2, 3));
		}
		else if (figure == "circle")
		{
			double r = double.Parse(Console.ReadLine());
			Console.WriteLine(Math.Round(Math.PI * r * r, 3));
		}
		else
		{
			Console.WriteLine("A NORMAL figure :)");
		}
	}
}