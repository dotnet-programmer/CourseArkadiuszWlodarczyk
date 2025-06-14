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

string name = "Arkadiusz";
Console.WriteLine(name);

Console.WriteLine("liczba = " + number);
Console.ReadLine();
#endregion Chapter 2.2 Variables