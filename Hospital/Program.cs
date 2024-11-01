internal class Hospital
{
    private static void Main()
    {
        int period = int.Parse(Console.ReadLine());
        int treatpatient = 0;
        int untreatpatient = 0;
        int doctors = 7;

        if (period > 0 && period <= 1000)
        {
            for (int day = 1; day <= period; day++)
            {
                int cntpatient = int.Parse(Console.ReadLine());
                if ((day % 3 == 0) && (untreatpatient > treatpatient))
                {
                    doctors++;
                }
                if (cntpatient > doctors)
                {
                    treatpatient += doctors;
                    untreatpatient += cntpatient - doctors;
                }
                else
                {
                    treatpatient += cntpatient;
                }
            }
        }
        Console.WriteLine($"Count of treated patient : {treatpatient}");
        Console.WriteLine($"Count of untreated patient : {untreatpatient}");
    }
}