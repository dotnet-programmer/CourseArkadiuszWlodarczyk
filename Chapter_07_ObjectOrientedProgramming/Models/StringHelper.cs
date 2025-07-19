namespace Chapter_07_ObjectOrientedProgramming.Models;

internal static class StringHelper
{
	public static bool IsCapitalized(this string value)
		=> char.IsUpper(value[0]);
}