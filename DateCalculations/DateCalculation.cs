class Date
{
	static void Main(string[] args)
	{
		string birthDate = Console.ReadLine();
		DateTime d = Convert.ToDateTime(birthDate).Date;
		DateTime.ParseExact(birthDate, "dd-MM-yyyy", null);
		DateTime birthday = DateTime.Parse(birthDate);
		DateTime after = birthday.AddDays(1000);
		Console.WriteLine(after);
	}
}