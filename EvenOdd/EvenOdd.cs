internal class EvenOdd
{
    private static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Even!");
        }
        else
        {
            Console.WriteLine("Odd!");
        }
    }
}