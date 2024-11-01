class Celcius
{
    static void Main()
    {
        Console.WriteLine("====================°C Degrees to °F Degrees====================");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Enter temperature in °C: ");
        double c = double.Parse(Console.ReadLine());
        double f = c * 1.8 + 32;
        Console.WriteLine("Temperature in Fahrenheit = {0}°F", f);
    }
}