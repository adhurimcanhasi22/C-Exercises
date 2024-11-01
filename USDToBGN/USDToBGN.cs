class Dollar
{
    static void Main()
    {
        Console.WriteLine("====================USD To BGN====================");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Enter the amount of US Dollars :");
        double d = double.Parse(Console.ReadLine());
        double b = d * 1.79549;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Dollars = {0}$", d);
        Console.WriteLine("BGN ={0}BGN ", Math.Round(b, 2));
    }
}