namespace Chapter_07_ObjectOrientedProgramming.Models;

internal class Car(string description, byte numberOfWheels)
{
	public string Description { get; set; } = description;
	public byte NumberOfWheels { get; private set; } = numberOfWheels;

	public Car(string description) : this(description, 4)
		=> Console.WriteLine("Constructor with 1 parameter and default value");

	public Car(Car car) : this(car.Description, car.NumberOfWheels)
		=> Console.WriteLine("Constructor with 1 parameter - another Car");
}