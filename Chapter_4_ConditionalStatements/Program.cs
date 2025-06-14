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
int a = 5, b = 5;
if (a < b)
{
	Console.WriteLine("a < b");
	Console.WriteLine("dostałeś się tutaj jako pierwszy i wygrałeś coś ;)");
}
else if (a > b)
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

if (a == b)
{
	Console.WriteLine("a jest równe b");
	a = 10;

	if (a > b)
	{
		Console.WriteLine("a zostało zmienione i jest teraz większe od b");
	}
	else if (a < b)
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
//Console.WriteLine(text);
Console.WriteLine(((a1 > b1) ? a1 : b1) + 100);
Console.ReadLine();
#endregion Chapter 4.3 Conditional operator