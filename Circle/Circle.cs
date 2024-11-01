class Circle
{
    static void Main()
    {
        Console.WriteLine("====================AREA/PERIMETER OF CIRCLE====================");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Enter the length of radius (cm)");
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        double perimeter = Math.PI * r * 2;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Radius = {0}cm", r);
        Console.WriteLine("Area of circle = {0}cm^2", area);
        Console.WriteLine("Perimetre of circle = {0}cm", perimeter);
    }
}