internal class Tickets
{
    private static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());

        double transportation;
        double tickets;
        if (category == "VIP")
        {
            if (people <= 4 && people > 0)
            {
                transportation = budget * 0.75;
                tickets = people * 499.99;
                double price = budget - transportation - tickets;

                if (price > 0)
                {
                    Console.WriteLine($"Yes!You have {Math.Round(price, 2)} leva left");
                }
                else
                {
                    price = price * (-1);
                    Console.WriteLine($"Not enough money!You need {Math.Round(price, 2)} leva");
                }
            }
            if (people <= 9 && people > 4)
            {
                transportation = budget * 0.6;
                tickets = people * 499.99;
                double price = budget - transportation - tickets;

                if (price > 0)
                {
                    Console.WriteLine($"Yes!You have {Math.Round(price, 2)} leva left");
                }
                else
                {
                    price = price * (-1);
                    Console.WriteLine($"Not enough money!You need {Math.Round(price, 2)} leva");
                }
            }
            if (people <= 24 && people > 9)
            {
                transportation = budget * 0.5;
                tickets = people * 499.99;
                double price = budget - transportation - tickets;

                if (price > 0)
                {
                    Console.WriteLine($"Yes!You have {Math.Round(price, 2)} leva left");
                }
                else
                {
                    price = price * (-1);
                    Console.WriteLine($"Not enough money!You need {Math.Round(price, 2)} leva");
                }
            }
            if (people <= 49 && people > 25)
            {
                transportation = budget * 0.4;
                tickets = people * 499.99;
                double price = budget - transportation - tickets;

                if (price > 0)
                {
                    Console.WriteLine($"Yes!You have {Math.Round(price, 2)} leva left");
                }
                else
                {
                    price = price * (-1);
                    Console.WriteLine($"Not enough money!You need {Math.Round(price, 2)} leva");
                }
            }
            if (people > 50)
            {
                transportation = budget * 0.25;
                tickets = people * 499.99;
                double price = budget - transportation - tickets;

                if (price > 0)
                {
                    Console.WriteLine($"Yes!You have {Math.Round(price, 2)} leva left");
                }
                else
                {
                    price = price * (-1);
                    Console.WriteLine($"Not enough money!You need {Math.Round(price, 2)} leva");
                }
            }
        }

        if (category == "Normal")
        {
            if (people <= 4 && people > 0)
            {
                transportation = budget * 0.75;
                tickets = people * 249.99;
                double price = budget - transportation - tickets;

                if (price > 0)
                {
                    Console.WriteLine($"Yes!You have {Math.Round(price, 2)} leva left");
                }
                else
                {
                    price = price * (-1);
                    Console.WriteLine($"Not enough money!You need {Math.Round(price, 2)} leva");
                }
            }
            if (people <= 9 && people > 4)
            {
                transportation = budget * 0.6;
                tickets = people * 249.99;
                double price = budget - transportation - tickets;

                if (price > 0)
                {
                    Console.WriteLine($"Yes!You have {Math.Round(price, 2)} leva left");
                }
                else
                {
                    price = price * (-1);
                    Console.WriteLine($"Not enough money!You need {Math.Round(price, 2)} leva");
                }
            }
            if (people <= 24 && people > 9)
            {
                transportation = budget * 0.5;
                tickets = people * 249.99;
                double price = budget - transportation - tickets;

                if (price > 0)
                {
                    Console.WriteLine($"Yes!You have {Math.Round(price, 2)} leva left");
                }
                else
                {
                    price = price * (-1);
                    Console.WriteLine($"Not enough money!You need {Math.Round(price, 2)} leva");
                }
            }
            if (people <= 49 && people > 25)
            {
                transportation = budget * 0.4;
                tickets = people * 249.99;
                double price = budget - transportation - tickets;

                if (price > 0)
                {
                    Console.WriteLine($"Yes!You have {Math.Round(price, 2)} leva left");
                }
                else
                {
                    price = price * (-1);
                    Console.WriteLine($"Not enough money!You need {Math.Round(price, 2)} leva");
                }
            }
            if (people > 50)
            {
                transportation = budget * 0.25;
                tickets = people * 249.99;
                double price = budget - transportation - tickets;

                if (price > 0)
                {
                    Console.WriteLine($"Yes!You have {Math.Round(price, 2)} leva left");
                }
                else
                {
                    price = price * (-1);
                    Console.WriteLine($"Not enough money!You need {Math.Round(price, 2)} leva");
                }
            }
        }
    }
}