namespace Chapter_07_ObjectOrientedProgramming.Models;

internal class CarWithNestedClass
{
	private readonly Engine _engine;

	public CarWithNestedClass()
		=> _engine = new() { Power = 700 };

	public uint GetPower()
		=> _engine.Power;

	private class Engine(uint power = 500)
	{
		public uint Power = power;
	}
}