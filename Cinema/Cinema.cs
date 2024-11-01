class Cinema
{
	static void Main()
	{
		string type = Console.ReadLine().ToLower();
		int r = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		int full = r * c;
		double income = 0;
		switch (type)
		{
			case "premier":
				income = full * 12.00;
				break;
			case "normal":
				income = full * 7.50;
				break;
			case "discount":
				income = full * 5.00;
				break;
		}
		Console.WriteLine(income);
	}
}