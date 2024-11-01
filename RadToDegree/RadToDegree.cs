class Radian
{
    static void Main()
    {
        Console.WriteLine("====================Radians to Degrees°====================");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Enter angle in radian :");
        double r = double.Parse(Console.ReadLine());
        double d = r * 180 / Math.PI;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Radians = {0}", r);
        Console.WriteLine("Degrees ={0}° ", Math.Round(d, 2));

    }
}