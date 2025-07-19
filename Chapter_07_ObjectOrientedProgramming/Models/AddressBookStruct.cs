namespace Chapter_07_ObjectOrientedProgramming.Models;

internal struct AddressBookStruct(string name, string surname, string phone)
{
	public string Name = name;
	public string Surname = surname;
	public string Phone = phone;
}