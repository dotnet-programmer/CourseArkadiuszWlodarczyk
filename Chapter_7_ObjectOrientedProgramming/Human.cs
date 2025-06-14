namespace Chapter_7_ObjectOrientedProgramming;

internal class Human
{
	private string _name = string.Empty;

	/*
     * [modyfikator] TYP_ZWRACANY NAZWA_FUNKCJI (typ_zm parametr1, typ_zm parametr2)
     * {
     *      return
     * }
     * */

	public string GetName()
		=> _name;

	public void SetName(string name)
		=> _name = name;
}