namespace Chapter_7_ObjectOrientedProgramming;

internal class Car
{
	public string Description { get; set; }
	public byte NumberOfWheels { get; private set; }

	public Car(string description) : this(description, 4)
		=> Console.WriteLine("Constructor with 1 parameter and default value");

	public Car(string description, byte numberOfWheels)
	{
		Description = description;
		NumberOfWheels = numberOfWheels;
	}

	public Car(Car car)
	{
		Description = car.Description;
		NumberOfWheels = car.NumberOfWheels;
	}
}