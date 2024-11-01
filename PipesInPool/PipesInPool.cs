class Pipes
{
	static void Main()
	{
		int V = int.Parse(Console.ReadLine());
		int P1 = int.Parse(Console.ReadLine());
		int P2 = int.Parse(Console.ReadLine());
		double H = double.Parse(Console.ReadLine());
		double water = P1 * H + P2 * H;
		if (water <= V)
		{
			Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%. ",
				Math.Truncate(water / V * 100),
				Math.Truncate(P1 * H / water * 100),
				Math.Truncate(P2 * H / water * 100));
		}
		else
		{
			Console.WriteLine("For {0} hours the pool overflows with {1} litres.", H, water - V);
		}
	}
}