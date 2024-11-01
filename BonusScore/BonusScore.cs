class BonusScore
{
	static void Main()
	{
		int points = int.Parse(Console.ReadLine());

		if (points <= 100 && points % 2 == 0)
		{
			int bonus = 6;
			Console.WriteLine(bonus);
			Console.WriteLine(bonus + points);
		}
		else if (points <= 100 && points % 5 == 0)
		{
			int bonus = 7;
			Console.WriteLine(bonus);
			Console.WriteLine(bonus + points);
		}
		else if (points <= 1000 && points > 100 && points % 2 == 0)
		{
			int bonus = ((20 * points) / 100) + 1;
			Console.WriteLine(bonus);
			Console.WriteLine(bonus + points);

		}
		else if (points <= 1000 && points > 100 && points % 5 == 0)
		{
			int bonus = ((20 * points) / 100) + 2;
			Console.WriteLine(bonus);
			Console.WriteLine(bonus + points);

		}
		else if (points > 1000 && points % 2 == 0)
		{
			int bonus = ((10 * points) / 100) + 1;
			Console.WriteLine(bonus);
			Console.WriteLine(bonus + points);

		}
		else if (points > 1000 && points % 5 == 0)
		{
			int bonus = ((10 * points) / 100) + 2;
			Console.WriteLine(bonus);
			Console.WriteLine(bonus + points);

		}
	}
}