internal class operations
{
    private static void Main()
    {
        decimal n1 = decimal.Parse(Console.ReadLine());
        string sign = Console.ReadLine();
        decimal n2 = decimal.Parse(Console.ReadLine());

        string output;
        decimal result = 0.00M;
        if (n2 == 0 && (sign.Equals("/") || sign.Equals("%")))
        {
            output = ($"Cannot divide {n1} by zero");
        }
        else if (sign.Equals("/"))
        {
            result = n1 / n2;
            output = string.Format("{0} {1} {2} = {3:F2}", n1, sign, n2, result);
        }
        else if (sign.Equals("%"))
        {
            result = n1 % n2;
            output = string.Format("{0} {1} {2} = {3:F2}", n1, sign, n2, result);
        }
        else
        {
            if (sign.Equals("+"))
            {
                result = n1 + n2;
            }
            else if (sign.Equals("-"))
            {
                result = n1 - n2;
            }
            else if (sign.Equals("*"))
            {
                result = n1 * n2;
            }
            output = string.Format("{0} {1} {2} = {3} - {4}", n1, sign, n2, result, result % 2 == 0 ? "even" : "odd");
        }
        Console.WriteLine(output);
    }
}