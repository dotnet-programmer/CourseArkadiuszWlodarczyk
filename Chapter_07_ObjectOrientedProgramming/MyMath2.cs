namespace Chapter_07_ObjectOrientedProgrammin;

internal class MyMath2
{
	public static int Abs(int x)
		=> x < 0 ? x * (-1) : x;

	public static int IncreaseBy5(int nr)
	{
		nr += 5;
		return nr;
	}

	public static int IncreaseBy5(ref int nr)
	{
		nr += 5;
		return nr;
	}

	public static void Reset(out int b)
		=> b = 0;

	public static int Add(params int[] args)
	{
		int Sum = 0;
		for (int i = 0; i < args.Length; i++)
		{
			Sum += args[i];
		}
		return Sum;
	}

	public static int Pow(int x, int y = 2)
	{
		int result = 1;
		for (int i = 0; i < y; i++)
		{
			result *= x;
		}
		return result;
	}
}