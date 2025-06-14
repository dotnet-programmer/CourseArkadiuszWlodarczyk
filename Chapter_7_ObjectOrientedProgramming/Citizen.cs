namespace Chapter_7_ObjectOrientedProgramming;

internal class Citizen(string name, string surname)
{
	public string Name { get; private set; } = name;
	public string Surname { get; set; } = surname;
}