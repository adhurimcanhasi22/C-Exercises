class inches
{
    static void Main()
    {
        Console.Write("Inches: ");
        double a = double.Parse(Console.ReadLine());
        double b = a * 2.54;
        Console.Write("Centimetres=");
        Console.WriteLine(b + "cm");

    }
}