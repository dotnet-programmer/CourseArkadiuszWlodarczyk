using Chapter_07_ObjectOrientedProgrammin;

#region Chapter 7.1 Object-Oriented Programming - Introduction
Console.WriteLine("Chapter 7.1 Object-Oriented Programming - Introduction");
//instancją klasy, czyli egzemplarzem jest obiekt, ponieważ sama klasa jest foremką do produkcji ;)
Human human1 = new();
Human human2 = new();
human1.SetName("Marek");
human2.SetName("Asia");
Console.WriteLine(human1.GetName());
Console.WriteLine(human2.GetName());
human1.SetName("Jacek");
Console.WriteLine(human1.GetName());
Console.ReadLine();
#endregion Chapter 7.1 Object-Oriented Programming - Introduction

#region Chapter 7.2 Constructors, static methods, fields, properties
Console.WriteLine("Chapter 7.2 Constructors, static methods, fields, properties");
Console.WriteLine(Player.NextId);
Player[] player = [new("nick"), new("Jakiś nick 1"), new("nick 2")];
Console.WriteLine(Player.NextId);
Console.WriteLine(player[0].Id);
Console.WriteLine(player[1].Id);
Console.WriteLine(player[2].Id);
Console.WriteLine(MyMath.Add(5, 7));
Console.WriteLine(MyMath.PI);
Console.ReadLine();
#endregion Chapter 7.2 Constructors, static methods, fields, properties

#region Chapter 7.3 Methods
Console.WriteLine("Chapter 7.3 Methods");
int a1 = -10;
Console.WriteLine(MyMath2.Abs(a1));
Console.WriteLine(MyMath2.Abs(55));
MyMath2.IncreaseBy5(ref a1);
Console.WriteLine(a1);

int b1;
MyMath2.Reset(out b1);
Console.WriteLine(b1);

Console.WriteLine(MyMath2.Add(1, 2, 1, 2, 1, 2, 5, 6, 7, 8));
Console.WriteLine(MyMath2.Pow(6));

Citizen citizen = new(surname: "Włodarczyk", name: "Arkadiusz");
Console.WriteLine(citizen.Name);
Console.ReadLine();
#endregion Chapter 7.3 Methods

#region Chapter 7.4 Constructors
Console.WriteLine("Chapter 7.4 Constructors");
Console.WriteLine(Welcomer.Message);
Console.WriteLine(Welcomer.Message);
Console.WriteLine(Welcomer.Message);
Console.WriteLine(Welcomer.Message);

Car car1 = new("Jakiś opis", 10);
Console.WriteLine(car1.Description);

Car car2 = new(car1);
Console.WriteLine(car2.Description);

car2.Description = "Nowy opis";
Console.WriteLine(car2.Description);
Console.WriteLine(car1.Description);

Console.WriteLine(car1.NumberOfWheels);
Console.WriteLine(car2.NumberOfWheels);
Console.ReadLine();
#endregion Chapter 7.4 Constructors

#region Chapter 7.5 Nested Classes
Console.WriteLine("Chapter 7.5 Nested Classes");
CarWithNestedClass carWithEngine = new();
Console.WriteLine(carWithEngine.GetPower());
Console.ReadLine();
#endregion Chapter 7.5 Nested Classes

#region Chapter 7.6 Inheritance
Console.WriteLine("Chapter 7.6 Inheritance");
MyPoint point = new(5, 10);
Console.WriteLine(point.GetCoordinations());
MyPoint3d point3d = new(5, 5555, 5123);
Console.WriteLine(point3d.GetCoordinations());
Console.ReadLine();
#endregion Chapter 7.6 Inheritance

#region Chapter 7.7 Polymorphism, Object Class, is, as operator and casting
Console.WriteLine("Chapter 7.7 Polymorphism, Object Class, is, as operator and casting");
MyPoint p1 = new(1, 5);
MyPoint p2 = new MyPoint3d(10, 20, 30);
MyPoint3d p3 = new(50, 100, 150);
//p3 = new Punkt(5, 20); ŹLE

Display(p1);
Display(p2);
Display(p3);

Console.WriteLine(getClassName(p1));
Console.WriteLine(getClassName(p2));
Console.WriteLine(getClassName(p3));

//Console.WriteLine(a.GetCoordinations());
//Console.WriteLine(((Punkt3d)b).GetCoordinations());
Console.ReadLine();

static void Display(MyPoint myPoint)
{
	if (myPoint is MyPoint3d point)
	{
		Console.WriteLine(point.GetCoordinations());
	}
	else
	{
		Console.WriteLine(myPoint.GetCoordinations());
	}

	//kiedy nie jest możliwe to w p3d będzie NULL;
	if (myPoint is not MyPoint3d p3d)
	{
		Console.WriteLine(myPoint.GetCoordinations());
	}
	else
	{
		Console.WriteLine(p3d.GetCoordinations());
	}
}

static string? getClassName(object x) 
	=> x.ToString();
#endregion Chapter 7.7 Polymorphism, Object Class, is, as operator and casting

#region Chapter 7.8 Virtual and Override
Console.WriteLine("Chapter 7.8 Virtual and Override");
MyPoint myPoint1 = new(1, 5);
MyPoint myPoint2 = new MyPoint3d(10, 20, 30);
MyPoint3d myPoint3 = new(50, 100, 150);
Console.WriteLine(myPoint2.GetCoordinationsVirtual());
DisplayVirtualOverride(myPoint1);
DisplayVirtualOverride(myPoint2);
DisplayVirtualOverride(myPoint3);
Console.WriteLine(getClassName(myPoint1));
Console.WriteLine(getClassName(myPoint2));
Console.WriteLine(getClassName(myPoint3));
Console.ReadLine();

static void DisplayVirtualOverride(MyPoint p) 
	=> Console.WriteLine(p.GetCoordinationsVirtual());
#endregion Chapter 7.8 Virtual and Override

#region Chapter 7.9 Abstract Classes and Methods
Console.WriteLine("Chapter 7.9 Abstract Classes and Methods");
Person person = new Employee("Arkadiusz", "Włodarczyk", 300000);
Person[] persons = new Person[4];
persons[0] = new Employee("Marek", "Nowak", 300000);
persons[1] = new Student("Jan", "Kowalski", 1);
persons[2] = person;
Person.WriteElements(persons);
Console.ReadLine();
#endregion Chapter 7.9 Abstract Classes and Methods

#region Chapter 7.10 Interfaces
Console.WriteLine("Chapter 7.10 Interfaces");
IBankAccount account1 = new BankAccount1();
IBankAccount account2 = new BankAccount2();
account1.Deposit(500);
account2.Deposit(500);
account1.TransferMoneyTo(account2, 100);
Console.WriteLine(account1.Balance);
Console.WriteLine(account2.Balance);
Console.ReadLine();
#endregion Chapter 7.10 Interfaces

#region Chapter 7.11 Sealed classes and methods
Console.WriteLine("Chapter 7.11 Sealed classes and methods");
#endregion Chapter 7.11 Sealed classes and methods

#region Chapter 7.12 Enum type
Console.WriteLine("Chapter 7.12 Enum type");
TimeOfDay timeOfDay = TimeOfDay.Morning;
Console.WriteLine(timeOfDay);
timeOfDay = (TimeOfDay)1;
Console.WriteLine(GetGreetings(timeOfDay));
Console.WriteLine(timeOfDay);
Console.ReadLine();

static string GetGreetings(TimeOfDay time) 
	=> time switch
	{
		TimeOfDay.Morning => "Good Morning",
		TimeOfDay.Afternoon => "Good Afternoon",
		TimeOfDay.Evening => "Good Evening",
		_ => "Something went wrong",
	};
#endregion Chapter 7.12 Enum type

#region Chapter 7.13 Namespace
Console.WriteLine("Chapter 7.13 Namespace");
#endregion Chapter 7.13 Namespace

#region Chapter 7.14 Structures
Console.WriteLine("Chapter 7.14 Structures");
AddressBookStruct book1;
AddressBookClass book2 = new();
AddressBookStruct book3 = new("Jan", "Kowalski", "111 222 333");

book1.Name = "Adam";
book1.Surname = "Nowak";
book1.Phone = "444 555 666";

book2.Name = "Martyna";
book2.Surname = "Nowak";
book2.Phone = "777 888 999";

AddressBookStruct[] book4 = new AddressBookStruct[40];
AddressBookClass[] book5 = new AddressBookClass[40];

book4[0].Name = "Arkadiusz";
book4[20].Name = "Arkadiusz";

for (int i = 0; i < book5.Length; i++)
{
	book5[i] = new AddressBookClass();
}

book5[0].Name = "Arkadiusz";

AddressBookStructTest(book1);
AddressBookClassTest(book2);
AddressBookStructTest(book3);

Console.WriteLine(book1.Name);
Console.WriteLine(book2.Name);
Console.WriteLine(book3.Name);
Console.ReadLine();

static void AddressBookStructTest(AddressBookStruct book) 
	=> book.Name = "test";
static void AddressBookClassTest(AddressBookClass book) 
	=> book.Name = "test";
#endregion Chapter 7.14 Structures

#region Chapter 7.15 Indexers
Console.WriteLine("Chapter 7.15 Indexers");
Sentence sentence = new("to jest testowe zdanie");
sentence[0] = "słowo";
Console.WriteLine(sentence[0]);
Console.ReadLine();
#endregion Chapter 7.15 Indexers

#region Chapter 7.16 Generic types
Console.WriteLine("Chapter 7.16 Generic types");
List<int> integerList = [10, 20];
List<string> stringList = ["text1", "text2"];
GenericClass<string> genericClass = new();
genericClass.SetValue("to jest tekst z klasy zwykla");
Console.WriteLine(genericClass.GetValue());
Console.WriteLine("integerList: ");
foreach (var item in integerList)
{
	Console.WriteLine(item);
}
Console.WriteLine("stringList: ");
foreach (var item in stringList)
{
	Console.WriteLine(item);
}
Console.ReadLine();
#endregion Chapter 7.16 Generic types

#region Chapter 7.17 Generic methods
Console.WriteLine("Chapter 7.17 Generic methods");
int numberToSwap1 = 10;
int numberToSwap2 = 20;
string textToSwap1 = "pies";
string textToSwap2 = "kot";

Swap(ref numberToSwap1, ref numberToSwap2);
Swap<string>(ref textToSwap1, ref textToSwap2);

Console.WriteLine("numberToSwap1 = " + numberToSwap1);
Console.WriteLine("numberToSwap2 = " + numberToSwap2);
Console.WriteLine("textToSwap1 = " + textToSwap1);
Console.WriteLine("textToSwap2 = " + textToSwap2);
Console.ReadLine();

static void Swap<T>(ref T a, ref T b) 
	=> (a, b) = (b, a);
#endregion Chapter 7.17 Generic methods

#region Chapter 7.18 Constraints, static and default values, generic inheritance
Console.WriteLine("Chapter 7.18 Constraints, static and default values, generic inheritance");
/* CONSTRAINT
 * where T : class - T MUSI być typu klasowego
 * where T : struct - T musi być typu strukturalnego
 * where T : INazwaInterfejsu - typ T musi implementować INazwaInterfejsu, lub też jest właśnie tym interfejsem
 * where T : NazwaKlasy - typ T musi być typem NazwaKlasy lub też typem dziedziączym po NazwaKlasy
 * where T : new() - wymaga aby typ T miał bezparametrowy konstruktor */
#endregion Chapter 7.18 Constraints, static and default values, generic inheritance

#region Chapter 7.19 Operator overloading and the copy constructor
Console.WriteLine("Chapter 7.19 Operator overloading and the copy constructor");
AccountBalance accountBalance1 = new(10, 5);
AccountBalance accountBalance2 = new(5, 10);
Console.WriteLine(accountBalance1);
Console.WriteLine(accountBalance2);
Console.WriteLine("Suma = " + (accountBalance1 + accountBalance2));
Console.WriteLine(accountBalance1.GetHashCode());
Console.WriteLine(accountBalance2.GetHashCode());
Console.ReadLine();
#endregion Chapter 7.19 Operator overloading and the copy constructor

#region Chapter 7.20 Custom cast operators
Console.WriteLine("Chapter 7.20 Custom cast operators");
AccountBalance accountBalance3 = new(10, 5);
AccountBalance accountBalance4 = new(5, 10);
Console.WriteLine(accountBalance4);

float number = (float)accountBalance3;
Console.WriteLine(number);

accountBalance4 = (AccountBalance)5.99;
Console.WriteLine(accountBalance4);
Console.ReadLine();
#endregion Chapter 7.20 Custom cast operators

#region Chapter 7.21 Null value for value types
Console.WriteLine("Chapter 7.21 Null value for value types");
int? nullableInt = GetSomethingFromDataBase(13);
Console.WriteLine($"{(nullableInt != null ? nullableInt : "nie podałeś wartości" )}");

int notNullableInt = nullableInt ?? 0; 
Console.WriteLine(notNullableInt);

int c = 10;
nullableInt = c;
Console.WriteLine(nullableInt);
Console.ReadLine();

static int? GetSomethingFromDataBase(int value) 
	=> value < 10 ? value : null;
#endregion Chapter 7.21 Null value for value types

#region Chapter 7.22 Extension methods
Console.WriteLine("Chapter 7.22 Extension methods");
string testText = "Pierwsza litera";
Console.WriteLine(testText.IsCapitalized());
Console.ReadLine();
#endregion Chapter 7.22 Extension methods

#region Chapter 7.23 Exception handling
Console.WriteLine("Chapter 7.23 Exception handling");
int value1 = 10;
string? text1 = Console.ReadLine();
try
{
	if (value1 == 10)
	{
		throw new MyException("value1 było równe 10");
	}

	int valueFromUser = Convert.ToInt32(text1);
	Console.WriteLine(value1 / valueFromUser);
}
catch (DivideByZeroException e)
{
	Console.WriteLine(e.Message);
}
catch (MyException e)
{
	Console.WriteLine("tu jest cos dopisane przez nas " + e.Message);
}
catch (Exception e)
{
	Console.WriteLine(e.Message);
}
finally
{
	Console.WriteLine("ja pokaze sie zawsze, sluze do czyszczenia, zamykania plikow, polaczen, a nie do tego co teraz robie");
}
Console.WriteLine("Kod po dzieleniu");
Console.ReadLine();
#endregion Chapter 7.23 Exception handling