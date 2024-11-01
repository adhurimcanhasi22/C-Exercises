internal class Exam
{
    private static void Main()
    {
        int exhour = int.Parse(Console.ReadLine());
        int exmin = int.Parse(Console.ReadLine());

        int enterhour = int.Parse(Console.ReadLine());
        int entermin = int.Parse(Console.ReadLine());

        int examtime = (exhour * 60) + exmin;
        int entertime = (enterhour * 60) + entermin;
        int difftime = entertime - examtime;

        string enterstudent = "Late";
        if (difftime < -30)
        {
            enterstudent = "early";
        }
        else if (difftime <= 30)
        {
            enterstudent = "On Time";
        }
        string result = string.Empty;
        if (difftime != 0)
        {
            int hoursdiff = Math.Abs(difftime / 60);
            int minutesdiff = Math.Abs(difftime % 60);

            if (hoursdiff > 0)
            {
                result = string.Format("{0}:{1:00} hours", hoursdiff, minutesdiff);
            }
            else
            {
                result = minutesdiff + " minutes";
            }
            if (difftime < 0)
            {
                result += " before the start";
            }
            else
            {
                result += " after the start";
            }
        }
        Console.WriteLine(enterstudent);
        if (!string.IsNullOrEmpty(result))
        {
            Console.WriteLine(result);
        }
    }
}