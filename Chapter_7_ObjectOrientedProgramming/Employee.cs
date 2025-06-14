namespace Chapter_7_ObjectOrientedProgramming;

internal class Employee : Person
{
	public double Salary { get; protected set; }

	public Employee() : base()
		=> Salary = 0;

	public Employee(string name, string surname, double salary) : base(name, surname)
		=> Salary = salary;

	public override string Description()
		=> Name + " " + Surname + ", wynagrodzenie: " + Salary;
}