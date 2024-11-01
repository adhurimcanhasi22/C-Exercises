class MetricConverter
{
	static void Main()
	{
		double size = double.Parse(Console.ReadLine());
		string inunit = Console.ReadLine().ToLower();
		string outunit = Console.ReadLine().ToLower();

		if (inunit == "mm" && outunit == "cm")
		{
			size = size / 10;
		}
		if (inunit == "mm" && outunit == "m")
		{
			size = size / 1000;
		}
		if (inunit == "mm" && outunit == "km")
		{
			size = size / 1000000;
		}
		if (inunit == "mm" && outunit == "mi")
		{
			size = size / 1609000;
		}
		if (inunit == "mm" && outunit == "ft")
		{
			size = size / 304;
		}
		if (inunit == "mm" && outunit == "in")
		{
			size = size / 25.4;
		}
		if (inunit == "mm" && outunit == "yd")
		{
			size = size / 914;
		}
		if (inunit == "cm" && outunit == "mm")
		{
			size = size * 10;
		}
		if (inunit == "cm" && outunit == "m")
		{
			size = size / 100;
		}
		if (inunit == "cm" && outunit == "km")
		{
			size = size / 100000;
		}
		if (inunit == "cm" && outunit == "mi")
		{
			size = size / 160900;
		}
		if (inunit == "cm" && outunit == "ft")
		{
			size = size / 30;
		}
		if (inunit == "cm" && outunit == "in")
		{
			size = size / 3;
		}
		if (inunit == "cm" && outunit == "yd")
		{
			size = size / 91;
		}
		if (inunit == "m" && outunit == "mm")
		{
			size = size * 1000;
		}
		if (inunit == "m" && outunit == "cm")
		{
			size = size * 100;
		}
		if (inunit == "m" && outunit == "km")
		{
			size = size * 1000;
		}
		if (inunit == "m" && outunit == "mi")
		{
			size = size / 1609;
		}
		if (inunit == "m" && outunit == "ft")
		{
			size = size / 3;
		}
		if (inunit == "m" && outunit == "in")
		{
			size = size * 39;
		}
		if (inunit == "m" && outunit == "yd")
		{
			size = size * 1.09;
		}
		if (inunit == "km" && outunit == "mm")
		{
			size = size * 1000000;
		}
		if (inunit == "km" && outunit == "cm")
		{
			size = size * 100000;
		}
		if (inunit == "km" && outunit == "m")
		{
			size = size * 1000;
		}
		if (inunit == "km" && outunit == "mi")
		{
			size = size / 1.6;
		}
		if (inunit == "km" && outunit == "ft")
		{
			size = size * 3281;
		}
		if (inunit == "m" && outunit == "in")
		{
			size = size * 39370;
		}
		if (inunit == "km" && outunit == "yd")
		{
			size = size * 1094;
		}
		if (inunit == "mi" && outunit == "mm")
		{
			size = size * 1609000;
		}
		if (inunit == "mi" && outunit == "cm")
		{
			size = size * 160900;
		}
		if (inunit == "mi" && outunit == "km")
		{
			size = size * 1.6;
		}
		if (inunit == "mi" && outunit == "m")
		{
			size = size * 1609;
		}
		if (inunit == "mi" && outunit == "ft")
		{
			size = size * 5280;
		}
		if (inunit == "mi" && outunit == "in")
		{
			size = size * 63360;
		}
		if (inunit == "mi" && outunit == "yd")
		{
			size = size * 1760;
		}
		if (inunit == "yd" && outunit == "mm")
		{
			size = size * 914;
		}
		if (inunit == "yd" && outunit == "cm")
		{
			size = size * 91;
		}
		if (inunit == "yd" && outunit == "km")
		{
			size = size / 1094;
		}
		if (inunit == "yd" && outunit == "mi")
		{
			size = size / 1760;
		}
		if (inunit == "yd" && outunit == "ft")
		{
			size = size * 3;
		}
		if (inunit == "yd" && outunit == "in")
		{
			size = size * 36;
		}
		if (inunit == "yd" && outunit == "m")
		{
			size = size / 1.094;
		}
		if (inunit == "ft" && outunit == "mm")
		{
			size = size * 304;
		}
		if (inunit == "ft" && outunit == "cm")
		{
			size = size * 30;
		}
		if (inunit == "ft" && outunit == "km")
		{
			size = size / 3281;
		}
		if (inunit == "ft" && outunit == "mi")
		{
			size = size / 5280;
		}
		if (inunit == "ft" && outunit == "m")
		{
			size = size / 3.2;
		}
		if (inunit == "ft" && outunit == "in")
		{
			size = size * 12;
		}
		if (inunit == "ft" && outunit == "yd")
		{
			size = size / 3;
		}
		if (inunit == "in" && outunit == "mm")
		{
			size = size * 25.4;
		}
		if (inunit == "in" && outunit == "cm")
		{
			size = size * 2.54;
		}
		if (inunit == "in" && outunit == "km")
		{
			size = size / 39370;
		}
		if (inunit == "in" && outunit == "mi")
		{
			size = size / 63360;
		}
		if (inunit == "in" && outunit == "ft")
		{
			size = size / 12;
		}
		if (inunit == "in" && outunit == "m")
		{
			size = size / 39;
		}
		if (inunit == "in" && outunit == "yd")
		{
			size = size / 36;
		}
		Console.WriteLine(size);
	}
}