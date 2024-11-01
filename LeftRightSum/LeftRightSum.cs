internal class sum
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftsum = 0;
        int rightsum = 0;

        for (int i = 0; i < n; i++)
        {
            leftsum = leftsum + int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            rightsum = rightsum + int.Parse(Console.ReadLine());
        }

        if (leftsum == rightsum)
        {
            Console.WriteLine(leftsum);
        }
        else
        {
            int difference = Math.Abs(rightsum - leftsum);
            Console.WriteLine(difference);
        }
    }
}