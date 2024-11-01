class Trapez
{
    static void Main()
    {
        Console.WriteLine("====================AREA OF TRAPEZ====================");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Enter the length of the first base (cm)");
        double b1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the second base (cm)");
        double b2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the height (cm)");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Base 1 = {0}cm", b1);
        Console.WriteLine("Base 2 = {0}cm", b2);
        Console.WriteLine("Height = {0}cm", h);
        double area = (b1 + b2) * h / 2;
        Console.WriteLine("Area of trapez = {0}cm^2", area);


    }
}