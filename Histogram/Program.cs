internal class Histogram
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double pca1 = 0;
        double pca2 = 0;
        double pca3 = 0;
        double pca4 = 0;
        double pca5 = 0;

        int cntpca1 = 0;
        int cntpca2 = 0;
        int cntpca3 = 0;
        int cntpca4 = 0;
        int cntpca5 = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 200)
            {
                cntpca1++;
            }
            else if (num >= 200 && num <= 399)
            {
                cntpca2++;
            }
            else if (num > 399 && num <= 599)
            {
                cntpca3++;
            }
            else if (num > 599 && num <= 799)
            {
                cntpca4++;
            }
            else
            {
                cntpca5++;
            }
        }
        pca1 = cntpca1 * 100 / n;
        pca2 = cntpca2 * 100 / n;
        pca3 = cntpca3 * 100 / n;
        pca4 = cntpca4 * 100 / n;
        pca5 = cntpca5 * 100 / n;
        Console.WriteLine("{0:f2}%", pca1);
        Console.WriteLine("{0:f2}%", pca2);
        Console.WriteLine("{0:f2}%", pca3);
        Console.WriteLine("{0:f2}%", pca4);
        Console.WriteLine("{0:f2}%", pca5);
    }
}