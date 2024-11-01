internal class even
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddsum = 0;
        int evensum = 0;
        for (int i = 0; i < n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evensum += element;
            }
            else
            {
                oddsum += element;
            }
        }
        if (oddsum == evensum)
        {
            Console.WriteLine(oddsum);
        }
        else
        {
            Console.WriteLine(Math.Abs(oddsum - evensum));
        }
    }
}