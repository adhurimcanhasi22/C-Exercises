class Seconds
{
	static void Main()
	{
		int sec1 = int.Parse(Console.ReadLine());
		int sec2 = int.Parse(Console.ReadLine());
		int sec3 = int.Parse(Console.ReadLine());
		int totalsec = sec1 + sec2 + sec3;
		int minutes = 0;
		int secleft = totalsec;
		if (secleft >= 60)
		{
			minutes++;
			secleft -= 60;
		}
		if (secleft >= 60)
		{
			minutes++;
			secleft -= 60;
		}
		Console.Write("{0}:", minutes);
		if (secleft < 10)
		{
			Console.Write("0");
		}
		Console.WriteLine(secleft);
	}
}