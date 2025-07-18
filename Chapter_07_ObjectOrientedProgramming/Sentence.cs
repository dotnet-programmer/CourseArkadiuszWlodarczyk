namespace Chapter_07_ObjectOrientedProgrammin;

internal class Sentence(string sentence)
{
	private readonly string?[] _words = sentence.Split();

	public string? this[int index]
	{
		get => index < _words.Length ? _words[index] : null;
		set
		{
			if (index < _words.Length)
			{
				_words[index] = value;
			}
		}
	}
}