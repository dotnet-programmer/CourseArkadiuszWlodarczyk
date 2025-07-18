#region Chapter 2.1 Basics
Console.WriteLine("Chapter 2.1 Basics");
//to zostanie wykonane jako pierwsze w tym programie
/*
	komentarz wiele linijek
*/
Console.WriteLine("Hello, World!");
#endregion Chapter 2.1 Basics

#region Chapter 2.2 Variables
Console.WriteLine("Chapter 2.2 Variables");
const double PI = 3.14;
Console.WriteLine(PI);
/* ZASADY NAZEWNICTWA
 * Nie można zacząć nazwy zmiennej od cyfry
 * Nie używamy spacji w nazwach zmiennych
 * Nie korzystamy ze specjalnych znaków typu ?
 * Nie korzystamy z zarezerwowanych słów
 * Możemy korzystać z polskich znaków (unikamy tego jak ognia!!)
 * liczy się wielkość liter!!
 * zmienne powinny być self-descriptive (samoopisujące się) */

//TYP_ZMIENNEJ NAZWA_ZMIENNEJ
int a;
a = 5;
int b = 10, c = 8;
sbyte number = 127;
Console.WriteLine($"a={a}, b={b}, c={c}, number={number}");
//  sbyte Liczba = 22;

/* LICZBY CAŁKOWITE - INTEGER
 * sbyte (signedbyte) - -128 do 127, na 8 bit, 1 bajcie
 * short - -32.768 do 32.767, na 16 bit, 2 bajtach
 * int - ~-2mld do +2 mld, na 32 bit, 4 bajtach
 * long - -2^63 do 2^63-1, na 64 bit, 8 bajtów
 * byte - 0 do 255, na 8 bitach
 * ushort (u - unsigned) - 0 do 65.535
 * uint - 0 do 2^32-1
 * ulong - 0 do 2^64-1
 *
 * LICZBY ZMIENNOPRZECINKOWE - FLOATING-POINT Types
 * float 7 znaków po przecinku - 1,5 * 10 ^-45 do 3.4 * 10 ^38 - 32 bitach
 * double od 15 do 16 - 5 * 10 ^ -324 do 1.7 * 10 ^ 308
 * decimal 28 znaków po przecinku od 1 * 10 ^ - 28 do 7.9 * 10 ^ 28 - 128 bitach
 *
 * BOOLEAN - prawda lub fałsz - true lub false
 * TYP ZNAKOWY - char
 * TYP CIĄGU ZNAKÓW - string */

/*
float lZm = 2.234112412F;
double lZm2 = 2.234112412;
decimal lZm3 = 2.2134123412341234123412341234M;
Console.WriteLine("lZM = " + lZm);
Console.WriteLine("lZM2 = " + lZm2);
Console.WriteLine("lZM3 = " + lZm3);
*/
bool isStart = false;
Console.WriteLine(isStart);

char oneChar = 'a';
Console.WriteLine(oneChar);

string name = "Imię";
Console.WriteLine(name);

Console.WriteLine("liczba = " + number);
Console.ReadLine();
#endregion Chapter 2.2 Variables

#region Chapter 3.1 Arithmetic operators and assignments
Console.WriteLine("Chapter 3.1 Arithmetic operators and assignments");
int a3 = 7, b3 = 10, c3 = 2;
//a3 += 7; // a3 = a3 + 7
//a3 -= 5; // a3 = a3 - 5
a3 /= 3; // a3 = 7 / 3 = 2 (i 1 / 3) - to jest usunięte ponieważ operujemy na liczbach całkowitych
Console.WriteLine($"{a3} {b3} {c3}");
// 23 % 10 = 2 i 3 / 10
// 7 % 3 = 2 i 1 / 3
Console.WriteLine(a3 + " + " + b3 + " = " + (a3 + b3));
Console.WriteLine(a3 + " - " + b3 + " = " + (a3 - b3));
Console.WriteLine(a3 + " / " + b3 + " = " + (a3 / (double)b3));
Console.WriteLine(a3 + " * " + b3 + " = " + (a3 * b3));
Console.WriteLine(a3 + " % " + b3 + " = " + (a3 % b3));
//POSTINKREMENTACJA
Console.WriteLine(a3++);
Console.WriteLine(a3);
Console.WriteLine(a3);
//PREINKREMENTACJA
Console.WriteLine(++a3);
Console.WriteLine(a3);
Console.WriteLine(a3);
//POSTDEKREMENTACJA
Console.WriteLine(a3--);
Console.WriteLine(a3);
Console.WriteLine(a3);
//PREDEKREMENTACJA
Console.WriteLine(--a3);
Console.WriteLine(a3);
Console.WriteLine(a3);
Console.ReadLine();
#endregion Chapter 3.1 Arithmetic operators and assignments

#region Chapter 3.2 Relational operators (comparisons)
Console.WriteLine("Chapter 3.2 Relational operators (comparisons)");
bool bool1 = true;
int zm1 = 4, zm2 = 5;
Console.WriteLine($"bool1 = {bool1}; zm1 >= zm2 = {zm1 >= zm2}");
/* == - zwróci prawdę (true) wtedy i tylko wtedy, gdy elementy są równe!
 * != - zwróci true, wtedy gdy elementy są nierówne
 * a > b - zwróci true, wtedy gdy element a jest większy od elementu b
 * a < b - zwróci true, wtedy gdy element a jest mniejszy od elementu b
 * a <= b - zwróci true, wtedy gdy element a jest mniejszy bądź też równy elementowi b
 * a >= b - zwróci true, wtedy gdy element a jest większy bądź tez równy elementowi b */
Console.ReadLine();
#endregion Chapter 3.2 Relational operators (comparisons)

#region Chapter 3.3 Logical operators
Console.WriteLine("Chapter 3.3 Logical operators");
// Console.WriteLine( ((12 > 7) && (9 > 4)) && (4 != 4));
Console.WriteLine(!((5 == 5) || (4 == 2)));
/* KONIUNKCJA - (i) - && - koniukcja jest prawdziwa wtedy i tylko wtedy, gdy OBA wyrażenia są prawdziwe
 * wyr1 wyr2   wynik
 * true true   true
 * true false  false
 * false true  false
 * false false false
 *
 * ALTERNATYWA - (lub) - || - alternatywa jest fałszywa wtedy i tylko wtedy, gdy OBA wyrażenia są fałszywe
 * wyr1 wyr2 wynik
 * true true true
 * true false true
 * false true true
 * false false false
 *
 * ZAPRZECZENIE - negacja - !
 * !(true) wynikiem bedzie false
 * !(false) wynikiem bedzie true */
Console.ReadLine();
#endregion Chapter 3.3 Logical operators

#region Chapter 3.4 Bit operators
Console.WriteLine("Chapter 3.4 Bit operators");
/* 0 - false
 * 1 - true
 * 1 2 6 = 1 * 10 ^ 2 + 2 * 10 ^ 1 + 6 * 10 ^ 0 = 100 + 20 + 6 = 126
 * 1 0 1 0 = 0 * 2 ^ 0 + 1 * 2 ^ 1 + 0 * 2 ^ 2 + 1 * 2 ^ 3 = 0 + 2 + 0 + 8 = 10
 * 1 0 1 0 = 8 + 2 = 10 */

/* KONIUNKCJI - &
 * 1 0 1 0
 * 0 0 1 0
 * -------
 * 0 0 1 0
 * */
Console.WriteLine(10 & 2);

/* ALTERNATYWA - |
 * 1 0 1 0
 * 0 0 1 0
 * -------
 * 1 0 1 0
 * */
Console.WriteLine(10 | 2);

/* ALTERNATYWA WYKLUCZAJĄCĄ (XOR) - ^ (albo)
 * 1 0 1 0
 * 0 0 1 0
 * -------           wyr1 wyr2 wynik
 * 1 0 0 0            0     0    0
 *                    0     1    1
 *                    1     0    1
 *                    1     1    0
 * */
Console.WriteLine(10 ^ 2);

/* ~ - negacja
 * ~(1 0 1 0) = (0 1 0 1) */
Console.WriteLine(~10);

/* 10 << 1
 *  0 0 0 0 0 0 0 1 0 1 0 (8 + 2)
 *  0 0 0 0 0 0 1 0 1 0 0 (8 + 2) * 2 = (8 * 2 + 2 * 2) = (20)
 *  10 >> 1
 *  0 0 0 0 0 0 0 1 0 1 0 (8 + 2)
 *  0 0 0 0 0 0 0 0 1 0 1 (8 + 2) / 2 = (4 + 1) = 5 */
Console.WriteLine(10 << 3);
Console.WriteLine(10 >> 1);
Console.ReadLine();
#endregion Chapter 3.4 Bit operators

#region Chapter 4.1 Conditional Statements if, else if, else and nested statements
Console.WriteLine("Chapter 4.1 Conditional Statements if, else if, else and nested statements");
/* wyrażenie to warunek
 * gdy warunek jest prawdziwy to zostanie wykonana instrukcja (true)
 * JEŚLI (warunek)
 *  instrukcja;
 * JEŚLI w innym wypadku (warunek)
 *  instrukcja;
 * CAŁKOWICIE w innym wypadku jeśli poprzednie warunki nie zostały spełnione
 *  instrukcja; */
int a4 = 5, b4 = 5;
if (a4 < b4)
{
	Console.WriteLine("a < b");
	Console.WriteLine("dostałeś się tutaj jako pierwszy i wygrałeś coś ;)");
}
else if (a4 > b4)
{
	Console.WriteLine("a > b");
}
else
{
	Console.WriteLine("a == b");
	Console.WriteLine("a jest równe b");
}

if (((5 > 7) && (7 > 4)) || (10 == 10))
{
	Console.WriteLine("((5 > 7) && (7 > 4)) || (10 == 10) zwraca prawdę");
}

if (a4 == b4)
{
	Console.WriteLine("a jest równe b");
	a4 = 10;

	if (a4 > b4)
	{
		Console.WriteLine("a zostało zmienione i jest teraz większe od b");
	}
	else if (a4 < b4)
	{
		Console.WriteLine("a zostało zmienione i jest teraz mniejsze od b");
	}
	else
	{
		Console.WriteLine("a dalej jest równe b");
	}
}
Console.ReadLine();
#endregion Chapter 4.1 Conditional Statements if, else if, else and nested statements

#region Chapter 4.2 The conditional switch statement
Console.WriteLine("Chapter 4.2 The conditional switch statement");
string countryName = "US";
switch (countryName)
{
	case "PL":
		Console.WriteLine("Jesteś z Polski :)");
		break;
	case "EN":
	case "US":
	case "UK":
		Console.WriteLine("You speak English");
		break;
	default:
		Console.WriteLine("Nie wiem po jakiemu mówisz ;)");
		break;
}
Console.ReadLine();
#endregion Chapter 4.2 The conditional switch statement

#region Chapter 4.3 Conditional operator
Console.WriteLine("Chapter 4.3 Conditional operator");
int a1 = 20;
int b1 = 10;
// (WARUNEK) ? gdy warunek jest spełniony (true) : gdy warunek jest niespełniony (false);
string text = (a1 > b1) ? "a jest większe od b" : "a jest mniejsze od b, bądź też równe b";
Console.WriteLine(text);
Console.WriteLine(((a1 > b1) ? a1 : b1) + 100);
Console.ReadLine();
#endregion Chapter 4.3 Conditional operator

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

//int[] array3 = new int[] { 1, 2, 3, 4, 5, 6 };
//int[] array3 = { 1, 2, 3, 4, 5, 6 };
int[] array3 = [1, 2, 3, 4, 5, 6];
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

//int[][] jaggedArray = new int[3][];
//jaggedArray[0] = new int[] { 5, 6, 7, 8 };
//jaggedArray[1] = new int[] { 5, 4 };
//jaggedArray[2] = new int[] { 4, 2, 1, 4, 5 };

//int[][] jaggedArrayInLine = new int[][]
//{
//	new int[] {1, 2, 3, 4, 5},
//	new int[] {2, 1},
//	new int[] {5, 7, 8}
//};

int[][] jaggedArrayNewStyle = 
[
	[5, 6, 7, 8], 
	[5, 4], 
	[4, 2, 1, 4, 5]
];

for (int i = 0; i < jaggedArrayNewStyle.GetLength(0); i++)
{
	for (int j = 0; j < jaggedArrayNewStyle[i].Length; j++)
	{
		Console.Write(jaggedArrayNewStyle[i][j] + " ");
	}
	Console.WriteLine();
}
Console.ReadLine();
#endregion Chapter 6.3 Multidimensional and jagged arrays