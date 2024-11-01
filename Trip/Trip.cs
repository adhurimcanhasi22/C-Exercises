internal class Trip
{
    private static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string destination = string.Empty;
        string holiday = string.Empty;
        decimal moneyspent = 0.00M;

        if (budget <= 100.00M)
        {
            destination = "Bulgaria";
            if (season.Equals("summer"))
            {
                moneyspent = 0.30M * budget;
                holiday = string.Format("Camp - {0:F2}", moneyspent);
            }
            else
            {
                moneyspent = 0.70M * budget;
                holiday = string.Format("Hotel - {0:F2}", moneyspent);
            }
        }
        else if (budget <= 1000.00M)
        {
            destination = "Balkans";
            if (season.Equals("summer"))
            {
                moneyspent = 0.40M * budget;
                holiday = string.Format("Camp - {0:F2}", moneyspent);
            }
            else
            {
                moneyspent = 0.80M * budget;
                holiday = string.Format("Hotel - {0:F2}", moneyspent);
            }
        }
        else
        {
            destination = "Europe";
            moneyspent = 0.90M * budget;
            holiday = string.Format("Hotel - {0:F2}", moneyspent);
        }
        Console.WriteLine("Somewhere in {0}", destination);
        Console.WriteLine(holiday);
    }
}