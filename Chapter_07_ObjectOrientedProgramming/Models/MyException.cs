namespace Chapter_07_ObjectOrientedProgramming.Models;

internal class MyException(string msg) : Exception(msg)
{
	// use primary constructor
	//public MyException(string msg) : base(msg)
	//{
	//}
}