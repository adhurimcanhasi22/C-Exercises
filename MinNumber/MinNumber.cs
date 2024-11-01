internal class Max
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = 100000000;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine(min);
    }
}