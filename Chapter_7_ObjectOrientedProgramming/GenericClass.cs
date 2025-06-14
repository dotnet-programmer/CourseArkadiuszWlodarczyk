namespace Chapter_7_ObjectOrientedProgramming;

internal class GenericClass<T>
{
	private T _genericVariable;

	public T GetValue() 
		=> _genericVariable;

	public void SetValue(T value) 
		=> _genericVariable = value;

	public T GenericVariable
	{
		get => _genericVariable;
		set => _genericVariable = value;
	}
}