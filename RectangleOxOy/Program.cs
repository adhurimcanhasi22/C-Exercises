class Rectangle
{
    static void Main()
    {
        Console.WriteLine("====================AREA/PERIMETER OF RECTANGLE====================");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Enter the coordinate of x1 (cm)");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinate of y1 (cm)");
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinate of x2 (cm)");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinate of y2 (cm)");
        double y2 = double.Parse(Console.ReadLine());
        double width = x2 - x1;
        double height = y2 - y1;
        double area = width * height;
        double perimeter = 2 * (width + height);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("x1,x2 = {0}cm,{1}cm", x1, x2);
        Console.WriteLine("y1,y2 = {0}cm,{1}cm", y1, y2);
        Console.WriteLine("Area = {0}cm^2", area);
        Console.WriteLine("Perimter = {0}cm", perimeter);
    }
}