class SoloLearn
{
    static void Main(string[] args)
    {
        int wins;
        int ties;

        //your code goes here
        wins = Convert.ToInt32(Console.ReadLine());
        ties = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(wins + 0.5 * ties);

    }
}