internal class test
{
    private static int GetMin(int a, int b, int c)
    {
        int minAB = Math.Min(a, b);
        int minABC = Math.Min(minAB, c);
        return minABC;
    }

    private static void Main()
    {
        int num1 = 5;
        int num2 = 20;
        int num3 = 10;
        int min = GetMin(GetMin(num1, num2, num3), num3, num3);
        Console.WriteLine(min);
    }
}