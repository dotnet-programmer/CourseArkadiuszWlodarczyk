namespace Chapter_07_ObjectOrientedProgramming.Models;

internal abstract class Person(string name, string surname)
{
	public string Name { get; protected set; } = name;
	public string Surname { get; protected set; } = surname;

	public Person() : this(string.Empty, string.Empty)
	{
	}

	public abstract string Description();

	public static void WriteElements(Person[] persons)
	{
		for (int i = 0; i < persons.Length; i++)
		{
			if (persons[i] != null)
			{
				Console.WriteLine(persons[i].Description());
			}
		}
	}

	public static void Test()
		=> Console.Write("Test");
}