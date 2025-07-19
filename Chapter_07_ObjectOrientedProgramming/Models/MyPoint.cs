namespace Chapter_07_ObjectOrientedProgramming.Models;

internal class MyPoint
{
	public int X { get; protected set; }
	public int Y { get; protected set; }

	public MyPoint()
	{
		Console.WriteLine("Jestem konstruktorem domyślnym z klasy MyPoint");
		X = 0;
		Y = 0;
	}

	public MyPoint(int x, int y)
	{
		Console.WriteLine("Jestem konstruktorem Punkt z 2 parametrami z klasy MyPoint");
		X = x;
		Y = y;
	}

	public string GetCoordinations()
		=> X + ", " + Y;

	virtual public string GetCoordinationsVirtual() 
		=> X + ", " + Y;
}