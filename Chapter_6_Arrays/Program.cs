#region Chapter 6.1 One-dimensional arrays
Console.WriteLine("");
// odczyt parametru funkcji Main - string[] args
for (int i = 0; i < args.Length; i++)
{
	Console.WriteLine(args[i]);
	if (args[0] == "-t")
	{
		// instrukcje;
	}
}
// int zm1, zm2, zm3, zm4;
/*				tab
 *   |-------|-------|-------|-------|
 *     tab[0]  tab[1]  tab[2]  tab[3]
 *   |-------|-------|-------|-------|
 *   NUMERUJEMY TABLICE OD 0 !!!!! */
int[] array1;
array1 = new int[10];
array1[0] = 5;
array1[1] = 7;
array1[2] = 4;
array1[3] = 10;
array1[4] = 20;
for (int i = 0; i < array1.Length; i++)
{
	Console.WriteLine(array1[i]);
}

int[] array2 = new int[4];
for (int i = 0; i < array2.Length; i++)
{
	array2[i] = i + 1;
	Console.WriteLine(array2[i]);
}

int[] array3 = new int[] { 1, 2, 3, 4, 5, 6 };
int[] array4 = { 1, 2, 3, 4, 5, 6 };
Console.WriteLine(array3[0]);
Console.ReadLine();
#endregion Chapter 6.1 One-dimensional arrays

#region Chapter 6.2 Foreach loop, var type variable
Console.WriteLine("");
int[] array5 = [1, 2, 3, 4, 5, 11, 12, 13, 14, 15];
foreach (var val in array5)
{
	Console.WriteLine($"{(val == 3 ? "Wartość jest równa 3" : val)}");
}
Console.ReadLine();
#endregion Chapter 6.2 Foreach loop, var type variable

#region Chapter 6.3 Multidimensional and jagged arrays
Console.WriteLine("");
string[,] array2d = new string[4, 3];
string[,] array2dInLine = { { "wart", "wart2" }, { "cos", "cos2" } };

for (int i = 0; i < array2d.GetLength(0); i++)
{
	for (int j = 0; j < array2d.GetLength(1); j++)
	{
		array2d[i, j] = "tab2D [ " + i + ", " + j + " ] = ";
	}
}

for (int i = 0; i < array2dInLine.GetLength(0); i++)
{
	for (int j = 0; j < array2dInLine.GetLength(1); j++)
	{
		Console.Write(array2dInLine[i, j] + " ");
	}
	Console.WriteLine();
}

int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 5, 6, 7, 8 };
jaggedArray[1] = new int[] { 5, 4 };
jaggedArray[2] = new int[] { 4, 2, 1, 4, 5 };

int[][] jaggedArrayInLine = new int[][]
{
	new int[] {1, 2, 3, 4, 5},
	new int[] {2, 1},
	new int[] {5, 7, 8}
};

for (int i = 0; i < jaggedArrayInLine.GetLength(0); i++)
{
	for (int j = 0; j < jaggedArrayInLine[i].Length; j++)
	{
		Console.Write(jaggedArrayInLine[i][j] + " ");
	}
	Console.WriteLine();
}
Console.ReadLine();
#endregion Chapter 6.3 Multidimensional and jagged arrays