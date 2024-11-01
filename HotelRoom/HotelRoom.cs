internal class Hotel
{
    private static void Main()
    {
        string month = Console.ReadLine();
        int days = int.Parse(Console.ReadLine());

        double apartment;
        double studio;

        switch (month)
        {
            case "May":
                if (days > 0 && days <= 7)
                {
                    apartment = days * 65;
                    studio = days * 50;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 7 && days <= 14)
                {
                    apartment = days * 65;
                    studio = days * 47.5;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 14)
                {
                    apartment = days * 58.5;
                    studio = days * 35;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }

                break;

            case "October":
                if (days > 0 && days <= 7)
                {
                    apartment = days * 65;
                    studio = days * 50;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 7 && days <= 14)
                {
                    apartment = days * 65;
                    studio = days * 47.5;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 14)
                {
                    apartment = days * 58.5;
                    studio = days * 35;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                break;

            case "June":
                if (days > 0 && days <= 7)
                {
                    apartment = days * 68.70;
                    studio = days * 75.20;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 7 && days <= 14)
                {
                    apartment = days * 68.70;
                    studio = days * 75.20;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 14)
                {
                    apartment = days * 61.83;
                    studio = days * 60.16;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                break;

            case "September":
                if (days > 0 && days <= 7)
                {
                    apartment = days * 68.70;
                    studio = days * 75.20;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 7 && days <= 14)
                {
                    apartment = days * 68.70;
                    studio = days * 75.20;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 14)
                {
                    apartment = days * 61.83;
                    studio = days * 60.16;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                break;

            case "July":
                if (days > 0 && days <= 7)
                {
                    apartment = days * 77;
                    studio = days * 76;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 7 && days <= 14)
                {
                    apartment = days * 77;
                    studio = days * 76;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 14)
                {
                    apartment = days * 69.3;
                    studio = days * 76;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                break;

            case "August":
                if (days > 0 && days <= 7)
                {
                    apartment = days * 77;
                    studio = days * 76;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 7 && days <= 14)
                {
                    apartment = days * 77;
                    studio = days * 76;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                else if (days > 14)
                {
                    apartment = days * 69.3;
                    studio = days * 76;
                    Console.WriteLine($"Apartment : {Math.Round(apartment, 2)}");
                    Console.WriteLine($"Studio : {Math.Round(studio, 2)}");
                }
                break;
        }
    }
}