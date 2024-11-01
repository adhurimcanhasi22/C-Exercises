class Money
{
	static void Main()
	{
		double bt = double.Parse(Console.ReadLine());
		double yuan = double.Parse(Console.ReadLine());
		double commission = double.Parse(Console.ReadLine());
		double btbgn = bt * 1168;
		double yuandoll = yuan * 0.15;
		double dollbgn = yuandoll * 1.76;
		double euro = (dollbgn + btbgn) / 1.95;
		double commfee = (5 * euro) / 100;
		double total = euro - commfee;
		Console.WriteLine(total);

	}
}