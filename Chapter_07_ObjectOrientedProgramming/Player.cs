namespace Chapter_07_ObjectOrientedProgrammin;

internal class Player
{
	private string? _nick;
	private readonly int _id;
	private static int _nextId = 0;

	public Player()
	{
		_nick = null;
		_id = 0;
	}

	public Player(string nick)
	{
		_nick = nick;
		_nextId++;
		_id = _nextId;
	}

	public string? Nick
	{
		get => _nick;
		
		//jesli admin albo jesli oplacone premium
		set => _nick = value;
	}

	public int Id => _id;

	public static int NextId => _nextId;
}