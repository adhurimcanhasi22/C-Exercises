internal class smartLilly
{
    private static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double wmp = double.Parse(Console.ReadLine());
        int tp = int.Parse(Console.ReadLine());

        int toys = 0;
        int savings = 0;
        int bdaymon = 10;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                savings += (bdaymon - 1);
                bdaymon += 10;
            }
            else
            {
                toys++;
            }
        }
        savings += toys * tp;
        Console.WriteLine(savings >= wmp ? $"Yes! {(savings - wmp):0.00}" : $"No!{(wmp - savings):0.00}");
    }
}