#region Chapter 5.1 Loops, Loop for
Console.WriteLine("Chapter 5.1 Loops, Loop for");
/* for (INICJALIZACJA ZMIENNYCH; WARUNEK; CO MA BYC WYKONANE PO KAŻDYM OBIEGU PĘTLI)
*      INSTRUKCJE */
for (int i = 0; i < 3; i++)
{
	Console.WriteLine(i);
}
Console.ReadLine();
#endregion Chapter 5.1 Loops, Loop for

#region Chapter 5.2 The while and do while loop
Console.WriteLine("Chapter 5.2 The while and do while loop");
int count = 0;
while (count < 3)
{
	Console.WriteLine(count);
	count++;
}
count = 0;
do
{
	Console.WriteLine(count);
	count++;
} while (count < 3);
Console.ReadLine();
#endregion Chapter 5.2 The while and do while loop

#region Chapter 5.3 Nested loops
Console.WriteLine("Chapter 5.3 Nested loops");
/* 1 2 3 4 5 6 7 8 9 10
 * 2 4 6 8 10 12 14 16 18 20
 * 3 6 9 12 15 18 21 24 27 30 */
for (int i = 1; i <= 10; i++)
{
	for (int j = 1; j <= 10; j++)
	{
		Console.Write(i * j + " ");
	}
	Console.WriteLine();
}
Console.ReadLine();
#endregion Chapter 5.3 Nested loops

#region Chapter 5.4 Break and continue statements
Console.WriteLine("Chapter 5.4 Break and continue statements");
/* 1 2 3 4 5 6 7 8 9 10
 * 2 4 6 8 10 12 14 16 18 20
 * 3 6 9 12 15 18 21 24 27 30 */
for (int i = 1; i <= 10; i++) //ilość wierszy, długość kolumny
{
	if (i == 3)
	{
		continue; //to co jest po CONTINUE nie jest wykonywane, natomiast pętla mimo wszystko jest KONTYNUOWANA
	}
	if (i == 4)
	{
		break; //to co jest po break; NIE JEST WYKONYWANE, z najbliższej PĘTLI wychodzimy
	}
	for (int j = 1; j <= 10; j++) //ilość kolumn, długość wiersza
	{
		if (j == 3)
		{
			continue;
		}
		Console.Write(i * j + " ");
	}
	Console.WriteLine();
}

for (int i = 1, j = 1; i <= 10; i++)
{
	Console.Write(i * j + " ");
	if (i == 10)
	{
		i = 0;
		j++;
		Console.WriteLine();
	}
	if (j == 10 + 1)
	{
		break;
	}
}
Console.ReadLine();
#endregion Chapter 5.4 Break and continue statements