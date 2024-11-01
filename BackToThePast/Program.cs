internal class backtothepast
{
    private static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int age = 18;
        if (year >= 1800 && year <= 1900)
        {
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= 12000 + age * 50;
                }
                age++;
            }
        }
        Console.WriteLine(money > 0 ? $"Yes!He will live carefree life and will have {money:f2} dollars left" : $"He will need {Math.Abs(money):f2} dollars to survive");
    }
}