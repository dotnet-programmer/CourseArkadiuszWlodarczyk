namespace Chapter_07_ObjectOrientedProgramming.Models;

internal class Citizen(string name, string surname)
{
	public string Name { get; private set; } = name;
	public string Surname { get; set; } = surname;
}