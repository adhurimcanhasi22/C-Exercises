﻿class stars
{
    static void Main()
    {

        var n = int.Parse(Console.ReadLine());
        Console.WriteLine(new String('*', n));

        for (int i = 1; i <= n - 2; i++)

        {

            Console.Write("*");
            Console.Write(new String(' ', n - 2));
            Console.WriteLine("*");

        }

        Console.WriteLine(new String('*', n));

    }

}

