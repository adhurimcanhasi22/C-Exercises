class TrainingLab
{
	static void Main()
	{
		double length = double.Parse(Console.ReadLine()) * 100;
		double width = double.Parse(Console.ReadLine()) * 100;

		int row = (int)length / 120;
		int col = ((int)width - 100) / 70;
		int seats = row * col - 3;
		Console.WriteLine(seats);
	}
}