class ChangingTiles
{
	static void Main()
	{
		int N = int.Parse(Console.ReadLine());
		double W = double.Parse(Console.ReadLine());
		double H = double.Parse(Console.ReadLine());
		int A = int.Parse(Console.ReadLine());
		int B = int.Parse(Console.ReadLine());

		double area = N * N;
		double tile = W * H;
		double bench = A * B;
		double coverarea = area - bench;
		double tileneed = coverarea / tile;
		double time = tileneed * 0.2;
		Console.WriteLine(tileneed + "tiles");
		Console.WriteLine(time + "minutes");
	}
}