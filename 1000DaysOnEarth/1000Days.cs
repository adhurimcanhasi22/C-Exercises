class Days
{
    static void Main()
    {
        Console.Write("Enter birth date (dd-MM-yyyy): ");
        string birthdateStr = Console.ReadLine();

        DateTime birthdate = DateTime.ParseExact(birthdateStr, "dd-MM-yyyy", null);

        DateTime targetDate = birthdate.AddDays(1000);

        string targetDateStr = targetDate.ToString("dd-MM-yyyy");

        Console.WriteLine($"Date on which 1000 days will have passed since birth: {targetDateStr}");
    }
}
