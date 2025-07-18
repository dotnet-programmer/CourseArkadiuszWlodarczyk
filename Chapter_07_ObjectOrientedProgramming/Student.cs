namespace Chapter_07_ObjectOrientedProgrammin;

internal class Student : Person
{
	public byte Semester { get; protected set; }

	public Student() : base()
		=> Semester = 1;

	public Student(string name, string surname, byte semester) : base(name, surname)
		=> Semester = semester;

	public override string Description()
		=> Name + " " + Surname + ", semestr: " + Semester;
}