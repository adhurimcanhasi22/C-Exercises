class VegetableMarket
{
	static void Main()
	{
		double vegprice = double.Parse(Console.ReadLine());
		double fruitprice = double.Parse(Console.ReadLine());
		int vegweight = int.Parse(Console.ReadLine());
		int fruitweight = int.Parse(Console.ReadLine());

		double vegcost = vegprice * vegweight;
		double fruitcost = fruitprice * fruitweight;

		double total = vegcost + fruitcost;
		Console.WriteLine(total / 1.94);
	}
}