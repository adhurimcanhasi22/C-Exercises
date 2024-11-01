class Greetings
{
    static void Main()
    {
        Console.WriteLine("Hello there!.What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Well Hi there {0},do you have a surname :)?", name);
        string surname = Console.ReadLine();
        Console.WriteLine("Nice to meet you {0} {1}.How old are you?", name, surname);
        string age = Console.ReadLine();
        Console.WriteLine("I'm also {0},what a coinsidence.What country are you from?", age);
        string country = Console.ReadLine();
        Console.WriteLine("Nice,I love {0}.", country);
    }
}