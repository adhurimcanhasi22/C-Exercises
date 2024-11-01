class rectangle
{

    static void Main()
    {
        Console.WriteLine("Enter height of rectagle in cm");
        var a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter width of rectangle in cm");
        var b = int.Parse(Console.ReadLine());

        int area = (a * b);
        Console.WriteLine("The area of rectsngle is :  " + area + "cm");

    }
}
