namespace Chapter_07_ObjectOrientedProgrammin;

internal class Citizen(string name, string surname)
{
	public string Name { get; private set; } = name;
	public string Surname { get; set; } = surname;
}