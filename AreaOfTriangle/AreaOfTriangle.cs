class Triangle
{
    static void Main()
    {
        Console.WriteLine("====================AREA OF TRIANGLE====================");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Enter the length of side a :");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of height h :");
        double h = double.Parse(Console.ReadLine());
        double area = a * h / 2;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Side a = {0}cm", a);
        Console.WriteLine("Height h = {0}cm", h);
        Console.WriteLine("Area = {0}cm^2", area);

    }
}