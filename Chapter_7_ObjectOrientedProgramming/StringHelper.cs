namespace Chapter_7_ObjectOrientedProgramming;

internal static class StringHelper
{
	public static bool IsCapitalized(this string value)
		=> char.IsUpper(value[0]);
}