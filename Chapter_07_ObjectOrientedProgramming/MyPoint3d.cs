namespace Chapter_07_ObjectOrientedProgrammin;

internal class MyPoint3d(int x, int y, int z) : MyPoint(x, y)
{
	public int Z { get; protected set; } = z;

	public new string GetCoordinations()
		=> base.GetCoordinations() + ", " + Z;

	override public string GetCoordinationsVirtual() 
		=> base.GetCoordinationsVirtual() + ", " + Z;
}