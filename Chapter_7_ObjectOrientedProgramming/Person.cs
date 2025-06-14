namespace Chapter_7_ObjectOrientedProgramming;

internal abstract class Person
{
	public string Name { get; protected set; }
	public string Surname { get; protected set; }

	public Person()
	{
		Name = string.Empty;
		Surname = string.Empty;
	}

	public Person(string name, string surname)
	{
		Name = name;
		Surname = surname;
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

	public void Test()
		=> Console.Write("Test");
}