namespace Chapter_7_ObjectOrientedProgramming;

internal class Welcomer
{
	public static string Message { get; private set; }

	static Welcomer()
	{
		Console.WriteLine("Welcomer constructor");
		Message = DateTime.Now.Hour < 17 ? "Dzień dobry" : "Dobry wieczór";
	}
}