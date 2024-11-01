class DailyEarnings
{
	static void Main()
	{
		int workday = int.Parse(Console.ReadLine());
		double dailyearnings = double.Parse(Console.ReadLine());
		double exrate = double.Parse(Console.ReadLine());

		double salary = workday * dailyearnings;
		double yearlyincome = salary * 12 + (salary * 2.5);
		double tax = (25 * yearlyincome) / 100;
		double usdincome = yearlyincome - tax;
		double eurincome = usdincome * exrate;
		double avgearning = eurincome / 365;
		Console.WriteLine(avgearning);
	}
}